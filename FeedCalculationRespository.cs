﻿using koi.respositories.Entities;
using koi.respositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koi.respositories
{
    public class FeedCalculationRespository : IFeedCalculationRespository
    {
        private readonly KoiFishManagementDbContext _dbContext;
        public FeedCalculationRespository(KoiFishManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<FeedCalculation>> GetAllFeedCalculations()
        {
            return await _dbContext.FeedCalculations.ToListAsync();
        }
    }
}
