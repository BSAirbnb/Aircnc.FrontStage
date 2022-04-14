using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.Transaction;
using Aircnc.FrontStage.Services.Transaction;
using AircncFrontStage.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;


namespace Aircnc.FrontStage.Controllers
{
    public class TransactionController : Controller
    {
        private readonly TransactionService _TransactionService;
        private readonly DBRepository _dbRepository;
        public TransactionController(TransactionService TransactionService , DBRepository dBRepository)
        {
            _TransactionService = TransactionService;
            _dbRepository = dBRepository;
        }
        /// <summary>
        /// 完成的交易
        /// </summary>
        /// <returns></returns>
        /// 
        [Authorize]
        public IActionResult CompletedTransaction() 
        {
            var UserId = int.Parse(User.Identity.Name) ;

            var completedList = _TransactionService.GetAllCompletedTransaction(UserId).OrderBy(x => x.CreateTime).Select(x=>new TransactionViewModel
            {
                CreateTime = x.CreateTime.ToString("yyyy-MM-dd"),
                TotalAmount = x.TotalAmount,
                StatusType = x.StatusType,
                RoomName = x.RoomName
            });
            ViewData["RoomName"] = _dbRepository.GetAll<Room>().Where(x => x.UserId == UserId).Select(x => x.RoomName);
            ViewData["completedList"] = JsonSerializer.Serialize(completedList);
            return View(completedList);
        }

        /// <summary>
        /// 將至的交易
        /// </summary>
        /// <returns></returns>
        /// 
        [Authorize]
        public IActionResult FutureTransaction() 
        {
            var UserId = int.Parse(User.Identity.Name);
            var transactionList = _TransactionService.GetAllFutureTransaction(UserId).OrderBy(x => x.CreateTime).Select(x => new TransactionViewModel
            {
                CreateTime = x.CreateTime.ToString("yyyy/MM/dd"),
                TotalAmount = x.TotalAmount,
                StatusType = x.StatusType,
                RoomName = x.RoomName
            });

            //撈出該房東底下所有的房源要放進下拉式選單裡面
            ViewData["RoomName"] = _dbRepository.GetAll<Room>().Where(x => x.UserId == UserId).Select(x => x.RoomName);
            ViewData["transactionList"] = JsonSerializer.Serialize(transactionList);

            return View(transactionList);
        }

        /// <summary>
        /// 總收益
        /// </summary>
        /// <returns></returns>
        /// 
        [Authorize]
        public IActionResult GrossEarnings() 
        {
            var UserId = int.Parse(User.Identity.Name);
            var grossList = _TransactionService.GetAllTransaction(UserId).OrderBy(x => x.CreateTime).Select(x => new TransactionViewModel
            {
                CreateTime = x.CreateTime.ToString("yyyy/MM/dd"),
                TotalAmount = x.TotalAmount,
                StatusType = x.StatusType,
                RoomName = x.RoomName
            });
            return View(grossList);
        }

    }
}
