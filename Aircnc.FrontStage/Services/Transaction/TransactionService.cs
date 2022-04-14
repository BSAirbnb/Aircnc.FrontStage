using Aircnc.FrontStage.Models.Dtos.Transaction;
using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services.Transaction
{
    public class TransactionService
    {
        private readonly DBRepository _dbRepository;
        public TransactionService(DBRepository dBRepository)
        {
            _dbRepository = dBRepository;
        }

        //撈全部完成的交易紀錄:錢已經轉給房東了
        public IEnumerable<TransactionDto> GetAllCompletedTransaction(int userId)
        {
            return _dbRepository.GetAll<TransactionStatus>().Where(x=>x.UserId == userId).Where(x=>x.StatusType ==StatusTypeEnum.TransferredToOwner ).Select(x=>new TransactionDto
            {
                TransactionStatusId = x.TransactionStatusId,
                UserId = x.UserId,
                OrderId = x.OrderId,
                CreateTime = x.CreateTime,
                AdminId = x.AdminId,
                TotalAmount = x.TotalAmount,
                StatusType = x.StatusType
            });
        }

        //撈即將入帳(還在系統中)的交易
        public IEnumerable<TransactionDto>GetAllFutureTransaction(int userId)
        {
            return _dbRepository.GetAll<TransactionStatus>().Where(transaction => transaction.UserId == userId).Where(transaction => transaction.StatusType == StatusTypeEnum.Pending).Select(transaction => new TransactionDto
            {
                TransactionStatusId = transaction.TransactionStatusId,
                UserId = transaction.UserId,
                OrderId = transaction.OrderId,
                CreateTime = transaction.CreateTime,
                AdminId = transaction.AdminId,
                TotalAmount = transaction.TotalAmount,
                StatusType = transaction.StatusType,

            });
        }

        //撈全部的交易(含在系統中&已轉帳給房東)
        public IEnumerable<TransactionDto>GetAllTransaction(int userId)
        {
            return _dbRepository.GetAll<TransactionStatus>().Where(x => x.UserId == userId).Where(x=>x.StatusType==StatusTypeEnum.Pending||x.StatusType==StatusTypeEnum.TransferredToOwner).Select(x => new TransactionDto
            {
                TransactionStatusId = x.TransactionStatusId,
                UserId = x.UserId,
                OrderId = x.OrderId,
                CreateTime = x.CreateTime,
                AdminId = x.AdminId,
                TotalAmount = x.TotalAmount,
                StatusType = x.StatusType

            });

        }
    }
}
