using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillsParkingLot.Enums;
using WillsParkingLot.Models;

namespace WillsParkingLot.Data.Repositories
{
    public interface IRateYearDayRepository
    {
        public Task<IEnumerable<RateYearDay>> GetRatesByCarTypeAsync(CarType carType);
    }
}
