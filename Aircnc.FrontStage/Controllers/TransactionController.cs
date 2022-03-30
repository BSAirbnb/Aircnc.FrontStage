using Aircnc.FrontStage.Models.ViewModels.Transaction;
using Aircnc.FrontStage.Services.Transaction;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class TransactionController : Controller
    {
        private readonly FutureTransactionService _futureTransactionService;
        public TransactionController(FutureTransactionService futureTransactionService)
        {
            _futureTransactionService = futureTransactionService;
        }
        /// <summary>
        /// 完成的交易
        /// </summary>
        /// <returns></returns>
        public IActionResult CompletedTransaction(int UserId) 
        {
            UserId = 1;
            var transactionList = _futureTransactionService.GetAllOrderTransactionStatus().Select(x=>new TransactionViewModel
            {
                CreateTime = x.CreateTime,
                TotalAmount = x.TotalAmount,
                StatusType = x.StatusType
            });
            return View(transactionList);
        }

        /// <summary>
        /// 將至的交易
        /// </summary>
        /// <returns></returns>
        public IActionResult FutureTransaction() 
        {
            return View();
        }

        /// <summary>
        /// 總收益
        /// </summary>
        /// <returns></returns>
        public IActionResult GrossEarnings() 
        {
            return View();
        }

    }
}
