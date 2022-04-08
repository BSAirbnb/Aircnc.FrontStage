﻿using Aircnc.FrontStage.Models.Dtos.Transaction;
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

        public IEnumerable<TransactionDto> GetAllOrderTransactionStatus()
        {
            return _dbRepository.GetAll<TransactionStatus>().Select(x=>new TransactionDto
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