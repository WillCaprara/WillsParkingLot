using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillsParkingLot.Data.Repositories;
using WillsParkingLot.Helpers;
using WillsParkingLot.Models;

namespace WillsParkingLot.Services
{
    public class ParkingService
    {
        private readonly IParkingRepository _parkingRepository;
        private readonly IParkingFeeHelper _parkingFeeHelper;
        private readonly IParkingFeeRepository _parkingFeeRepository;
        private readonly IRateYearDayRepository _rateYearRepository;

        public ParkingService(IParkingRepository parkingRepository, IParkingFeeHelper parkingFeeHelper, IParkingFeeRepository parkingFeeRepository, IRateYearDayRepository rateYearDayRepository)
        {
            _parkingRepository = parkingRepository;
            _parkingFeeHelper = parkingFeeHelper;
            _parkingFeeRepository = parkingFeeRepository;
            _rateYearRepository = rateYearDayRepository;
        }

        public async Task<IEnumerable<Parking>> GetAllCarsCurrentlyInTheParkingLot()
        {
            try
            {
                var result = await _parkingRepository.GetAllCarsCurrentlyInThePrkingLotAsync();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Parking>> GetAllCarsThatHaveLeftTheParkingLot(DateTime? dtFrom, DateTime? dtToo)
        {
            try
            {
                var result = await _parkingRepository.GetAllCarsThatHaveLeftTheParkingLotAsync(dtFrom, dtToo);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Earnings> GetTotalEarnings(DateTime? dtFrom, DateTime? dtToo)
        {
            try
            {
                var result = await _parkingFeeRepository.GetEarningsAsync(dtFrom, dtToo);

                var earnings = new Earnings()
                {
                    GrandTotal = result.Sum(c => c.TotalParkingFeeCollected),
                    EarningsForCompactCars = result.Where(c => c.Parking.Car.Type == Enums.CarType.Compact).Sum(c => c.TotalParkingFeeCollected),
                    EarningsForSUVs = result.Where(c => c.Parking.Car.Type == Enums.CarType.SUV).Sum(c => c.TotalParkingFeeCollected),
                    EarningsForLargeCars = result.Where(c => c.Parking.Car.Type == Enums.CarType.Large).Sum(c => c.TotalParkingFeeCollected)
                };

                return earnings;
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Parking>> SearchCars(Car car)
        {
            try
            {
                car.LicensePlate = car.LicensePlate ?? string.Empty;
                car.Color = car.Color ?? string.Empty;
                car.Model = car.Model ?? string.Empty;

                var parking = new Parking()
                {
                    Car = car
                };

                var result = await _parkingRepository.SearchCarsAsync(parking);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CheckInCar(Car car)
        {
            try
            {
                var parking = new Parking()
                {
                    ArriveTime = DateTime.Now,
                    Car = car
                };

                _parkingRepository.CheckInCar(parking);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ParkingFee> CheckoutCar(Parking parking)
        {
            try
            {
                //parking.LeaveTime = new DateTime(2021, 10, 22, 9, 30, 48);
                //parking.LeaveTime = new DateTime(2021, 10, 26, 9, 00, 48);
                parking.LeaveTime = DateTime.Now;
                _parkingRepository.CheckOutCar(parking);

                var totalParkingFee = await _parkingFeeHelper.GetParkingFee(parking);

                var parkingFee = new ParkingFee()
                {
                    ParkingId = parking.ParkingId,
                    TotalParkingFeeCollected = totalParkingFee.Value
                };

                _parkingFeeRepository.SaveCollectedParkingFee(parkingFee);

                return parkingFee;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
