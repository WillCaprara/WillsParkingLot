using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WillsParkingLot.Models;

namespace WillsParkingLot.Data.Repositories
{
    public interface IParkingRepository
    {
        public Task<IEnumerable<Parking>> GetAllCarsCurrentlyInThePrkingLot();
        public Task<IEnumerable<Parking>> GetAllCarsThatHaveLeftTheParkingLot(DateTime dtFrom, DateTime dtToo);
        public Task<IEnumerable<Parking>> SearchCars(Parking parking);
        public Parking GetByParkingId(int parkingId);
        public void CheckInCar(Parking parking);
        public void CheckOutCar(Parking parking);
    }
}
