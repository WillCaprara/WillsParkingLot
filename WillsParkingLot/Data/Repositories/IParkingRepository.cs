using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WillsParkingLot.Models;

namespace WillsParkingLot.Data.Repositories
{
    public interface IParkingRepository
    {
        public Task<IEnumerable<Parking>> GetAllCarsCurrentlyInThePrkingLotAsync();
        public Task<IEnumerable<Parking>> GetAllCarsThatHaveLeftTheParkingLotAsync(DateTime? dtFrom, DateTime? dtToo);
        public Task<IEnumerable<Parking>> SearchCarsAsync(Parking parking);
        public Parking GetByParkingId(int parkingId);
        public void CheckInCar(Parking parking);
        public void CheckOutCar(Parking parking);
    }
}
