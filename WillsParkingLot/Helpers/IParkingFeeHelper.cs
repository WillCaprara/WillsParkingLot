using System.Threading.Tasks;
using WillsParkingLot.Models;

namespace WillsParkingLot.Helpers
{
    public interface IParkingFeeHelper
    {
        public Task<decimal?> GetParkingFee(Parking parking);
    }
}
