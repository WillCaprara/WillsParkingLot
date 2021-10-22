using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillsParkingLot.DbContexts;
using WillsParkingLot.Enums;
using WillsParkingLot.Models;

namespace WillsParkingLot.Data.Repositories.Implementation
{
    public class RateYearDayRepository : IRateYearDayRepository
    {
        private readonly WillsParkingLotContext _dbContext;

        public RateYearDayRepository(WillsParkingLotContext dbContext)
        {
            _dbContext = dbContext;          
        }

        public async Task<IEnumerable<RateYearDay>> GetRatesByCarTypeAsync(CarType carType)
        {
            return await _dbContext.RateYearsDays.Where(c => c.CarType == carType).ToListAsync();
        }
    }
}
