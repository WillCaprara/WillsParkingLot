using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WillsParkingLot.Models;

namespace WillsParkingLot.Data.Repositories
{
    public interface IParkingFeeRepository
    {
        public void SaveCollectedParkingFee(ParkingFee parkingFee);
        public Task<IEnumerable<ParkingFee>> GetEarningsAsync(DateTime? dtFrom, DateTime? dtToo);
    }
}
