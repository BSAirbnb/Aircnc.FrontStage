using Aircnc.FrontStage.Models.ViewModels.Transaction;
using Aircnc.FrontStage.Services.Transaction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class TransactionController : Controller
    {
        private readonly TransactionService _TransactionService;
        public TransactionController(TransactionService TransactionService)
        {
            _TransactionService = TransactionService;
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
                CreateTime = x.CreateTime,
                TotalAmount = x.TotalAmount,
                StatusType = x.StatusType
            });
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
                CreateTime = x.CreateTime,
                TotalAmount = x.TotalAmount,
                StatusType = x.StatusType,
                RoomName = x.RoomName
            });
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
                CreateTime = x.CreateTime,
                TotalAmount = x.TotalAmount,
                StatusType = x.StatusType
            });
            return View(grossList);
        }

    }
}
