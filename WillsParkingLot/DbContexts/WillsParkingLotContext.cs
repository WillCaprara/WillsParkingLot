using Microsoft.EntityFrameworkCore;
using WillsParkingLot.Models;

namespace WillsParkingLot.DbContexts
{
    public class WillsParkingLotContext: DbContext
    {
        public WillsParkingLotContext(DbContextOptions<WillsParkingLotContext> options): base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<RateYearDay> RateYearsDays { get; set; }

        public DbSet<ParkingFee> ParkingFees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Year>().HasData(
                new Year
                {
                    YearId = 1,
                    YearNumber = 2021
                },
                new Year
                {
                    YearId = 2,
                    YearNumber = 2022
                }
            );

            modelBuilder.Entity<Day>().HasData(
                new Day
                { 
                    DayId = 1,
                    DayName = "Monday"
                },
                new Day
                {
                    DayId = 2,
                    DayName = "Tuesday"
                },
                new Day
                {
                    DayId = 3,
                    DayName = "Wednesday"
                },
                new Day
                {
                    DayId = 4,
                    DayName = "Thursday"
                },
                new Day
                {
                    DayId = 5,
                    DayName = "Friday"
                },
                new Day
                {
                    DayId = 6,
                    DayName = "Saturday"
                },
                new Day
                {
                    DayId = 7,
                    DayName = "Sunday"
                }
            );

            modelBuilder.Entity<RateYearDay>().HasData(
                new RateYearDay() 
                {
                    RateYearDayId = 1,
                    YearId = 1, //2021
                    DayId = 1,  //Monday
                    Rate = 20,
                    CarType = Enums.CarType.Compact,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 2,
                    YearId = 1, //2021
                    DayId = 2,  //Tuesday
                    Rate = 20,
                    CarType = Enums.CarType.Compact,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 3,
                    YearId = 1, //2021
                    DayId = 3,  //Wednesday
                    Rate = 20,
                    CarType = Enums.CarType.Compact,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 4,
                    YearId = 1, //2021
                    DayId = 4,  //Thursday
                    Rate = 20,
                    CarType = Enums.CarType.Compact,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 5,
                    YearId = 1, //2021
                    DayId = 5,  //Friday
                    Rate = 20,
                    CarType = Enums.CarType.Compact,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 6,
                    YearId = 1, //2021
                    DayId = 6,  //Saturday
                    Rate = 20,
                    CarType = Enums.CarType.Compact,
                    IncrementPercent = 15,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 7,
                    YearId = 1, //2021
                    DayId = 7,  //Sunday
                    Rate = 0,
                    CarType = Enums.CarType.Compact,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 8,
                    YearId = 1, //2021
                    DayId = 1,  //Monday
                    Rate = 22,
                    CarType = Enums.CarType.SUV,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 9,
                    YearId = 1, //2021
                    DayId = 2,  //Tuesday
                    Rate = 22,
                    CarType = Enums.CarType.SUV,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 10,
                    YearId = 1, //2021
                    DayId = 3,  //Wednesday
                    Rate = 22,
                    CarType = Enums.CarType.SUV,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 11,
                    YearId = 1, //2021
                    DayId = 4,  //Thursday
                    Rate = 22,
                    CarType = Enums.CarType.SUV,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 12,
                    YearId = 1, //2021
                    DayId = 5,  //Friday
                    Rate = 22,
                    CarType = Enums.CarType.SUV,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 13,
                    YearId = 1, //2021
                    DayId = 6,  //Saturday
                    Rate = 22,
                    CarType = Enums.CarType.SUV,
                    IncrementPercent = 15,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 14,
                    YearId = 1, //2021
                    DayId = 7,  //Sunday
                    Rate = 0,
                    CarType = Enums.CarType.SUV,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 15,
                    YearId = 1, //2021
                    DayId = 1,  //Monday
                    Rate = 25,
                    CarType = Enums.CarType.Large,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 16,
                    YearId = 1, //2021
                    DayId = 2,  //Tuesday
                    Rate = 25,
                    CarType = Enums.CarType.Large,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 17,
                    YearId = 1, //2021
                    DayId = 3,  //Wednesday
                    Rate = 25,
                    CarType = Enums.CarType.Large,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 18,
                    YearId = 1, //2021
                    DayId = 4,  //Thursday
                    Rate = 25,
                    CarType = Enums.CarType.Large,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 19,
                    YearId = 1, //2021
                    DayId = 5,  //Friday
                    Rate = 25,
                    CarType = Enums.CarType.Large,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 20,
                    YearId = 1, //2021
                    DayId = 6,  //Saturday
                    Rate = 25,
                    CarType = Enums.CarType.Large,
                    IncrementPercent = 15,
                    RegistrationDate = System.DateTime.Now
                },
                new RateYearDay()
                {
                    RateYearDayId = 21,
                    YearId = 1, //2021
                    DayId = 7,  //Sunday
                    Rate = 0,
                    CarType = Enums.CarType.Large,
                    RegistrationDate = System.DateTime.Now
                }
            );
        }
    }
}
