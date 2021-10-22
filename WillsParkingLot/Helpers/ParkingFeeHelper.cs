using System;
using System.Linq;
using System.Threading.Tasks;
using WillsParkingLot.Data.Repositories;
using WillsParkingLot.Models;

namespace WillsParkingLot.Helpers
{
    public class ParkingFeeHelper: IParkingFeeHelper
    {
        private readonly IRateYearDayRepository _rateYearDayRepository;

        public ParkingFeeHelper(IRateYearDayRepository rateYearDayRepository)
        {
            _rateYearDayRepository = rateYearDayRepository;
        }

        public async Task<decimal?> GetParkingFee(Parking parking)
        {
            var currentRates = await _rateYearDayRepository.GetCurrentRatesByType(parking.Car.Type);

            var totalHoursParked = (parking.LeaveTime.Value - parking.ArriveTime).TotalHours;
            var totalDaysParked = (totalHoursParked / 24 < 1) ? 1 : (totalHoursParked / 24);

            decimal? parkingFeeToPay = 0;

            for (int i = 1; i <= Math.Truncate(totalDaysParked); i++)
            {
                int dayOfWeek = parking.ArriveTime.DayOfWeek == DayOfWeek.Sunday? 7 : (int)parking.ArriveTime.DayOfWeek;
                var rateForCurrentDay = currentRates.SingleOrDefault(c => c.DayId == dayOfWeek);

                decimal? incrementPercent = 0;
                if (rateForCurrentDay.IncrementPercent != null)
                {
                    incrementPercent = rateForCurrentDay.Rate + (rateForCurrentDay.Rate * (rateForCurrentDay.IncrementPercent / 100));
                }

                parkingFeeToPay = parkingFeeToPay + (rateForCurrentDay.Rate + incrementPercent);
            }

            return parkingFeeToPay;
        }
    }
}
