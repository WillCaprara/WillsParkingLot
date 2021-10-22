using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillsParkingLot.DbContexts;
using WillsParkingLot.Models;

namespace WillsParkingLot.Data.Repositories.Implementation
{
    public class ParkingRepository : IParkingRepository
    {
        private readonly WillsParkingLotContext _dbContext;

        public ParkingRepository(WillsParkingLotContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Parking>> GetAllCarsCurrentlyInThePrkingLot()
        {
            return await _dbContext.Parkings.Include(c=> c.Car)
                                            .Where(x => x.LeaveTime == null).ToListAsync();
        }

        public async Task<IEnumerable<Parking>> GetAllCarsThatHaveLeftTheParkingLot(DateTime dtFrom, DateTime dtToo)
        {
            return await _dbContext.Parkings.Include(c => c.Car)
                                            .Where(x => x.LeaveTime >= dtFrom && x.LeaveTime <= dtToo).ToListAsync();
        }

        public async Task<IEnumerable<Parking>> SearchCarsAsync(Parking parking)
        {
            var result = new List<Parking>();

            switch (parking.Car.Type)
            {
                case Enums.CarType.All:
                    {
                        result= await _dbContext.Parkings.Include(c => c.Car)
                                            .Where(x => x.Car.LicensePlate.Trim().ToUpper().Contains(parking.Car.LicensePlate.Trim().ToUpper())
                                                    && x.Car.Model.ToUpper().Trim().Contains(parking.Car.Model.Trim().ToUpper())
                                                    && x.Car.Color.ToUpper().Trim().Contains(parking.Car.Color.Trim().ToUpper())).ToListAsync();
                    }
                    break;
                case Enums.CarType.Compact:
                case Enums.CarType.SUV:
                case Enums.CarType.Large:
                    {
                        result= await _dbContext.Parkings.Include(c => c.Car)
                                            .Where(x => x.Car.LicensePlate.Trim().ToUpper().Contains(parking.Car.LicensePlate.Trim().ToUpper())
                                                    && x.Car.Model.Trim().ToUpper().Contains(parking.Car.Model.Trim().ToUpper())
                                                    && x.Car.Color.Trim().ToUpper().Contains(parking.Car.Color.Trim().ToUpper())
                                                    && x.Car.Type == parking.Car.Type).ToListAsync();
                    }
                    break;
            }

            return result;
        }

        public Parking GetByParkingId(int parkingId)
        {
            return _dbContext.Parkings.Find(parkingId);
        }

        public void CheckInCar(Parking parking)
        {
            _dbContext.Parkings.Add(parking);
            _dbContext.SaveChanges();
        }

        public void CheckOutCar(Parking parking)
        {
            _dbContext.Entry(parking).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
