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
            var currentRates = await _rateYearDayRepository.GetRatesByCarTypeAsync(parking.Car.Type);

            var totalHoursParked = (parking.LeaveTime.Value - parking.ArriveTime).TotalHours;
            var totalDaysParked = (totalHoursParked / 24 < 1) ? 1 : (totalHoursParked / 24);

            var extraDay = totalDaysParked % 1 > 0 ? 1 : 0;

            decimal? parkingFeeToPay = 0;

            var currentParkDate = parking.ArriveTime;

            for (int i = 1; i <= Math.Truncate(totalDaysParked) + extraDay; i++)
            {
                if (i != 1)
                {
                    currentParkDate = currentParkDate.AddDays(1);
                }

                int dayOfWeek = currentParkDate.DayOfWeek == DayOfWeek.Sunday? 7 : (int)currentParkDate.DayOfWeek;
                var rateForCurrentDay = currentRates.SingleOrDefault(c => c.DayId == dayOfWeek);

                decimal? incrementPercent = 0;
                if (rateForCurrentDay.IncrementPercent != null)
                {
                    incrementPercent = rateForCurrentDay.Rate + (rateForCurrentDay.Rate * (rateForCurrentDay.IncrementPercent / 100));
                }

                parkingFeeToPay = parkingFeeToPay + (incrementPercent != 0? incrementPercent: rateForCurrentDay.Rate);
            }

            return parkingFeeToPay;
        }
    }
}
