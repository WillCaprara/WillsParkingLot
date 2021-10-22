using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillsParkingLot.DbContexts;
using WillsParkingLot.Models;

namespace WillsParkingLot.Data.Repositories.Implementation
{
    public class ParkingFeeRepository: IParkingFeeRepository
    {
        private readonly WillsParkingLotContext _dbContext;

        public ParkingFeeRepository(WillsParkingLotContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveCollectedParkingFee(ParkingFee parkingFee)
        {
            _dbContext.ParkingFees.Add(parkingFee);
            _dbContext.SaveChanges();
        }

        public async Task<IEnumerable<ParkingFee>> GetEarningsAsync(DateTime? dtFrom, DateTime? dtToo)
        {
            return await _dbContext.ParkingFees.Include(c => c.Parking)
                                               .Include(c => c.Parking.Car)
                                               .Where(c => c.Parking.LeaveTime.Value.Date >= dtFrom.Value.Date && c.Parking.LeaveTime.Value.Date <= dtToo.Value.Date).ToListAsync();
        }
    }
}
