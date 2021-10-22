using WillsParkingLot.Models;

namespace WillsParkingLot.Data.Repositories
{
    public interface IParkingFeeRepository
    {
        public void SaveCollectedParkingFee(ParkingFee parkingFee);
    }
}
