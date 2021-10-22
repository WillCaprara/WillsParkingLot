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
    }
}
