using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WillsParkingLot.Enums;

namespace WillsParkingLot.Models
{
    public class RateYearDay
    {
        [Key]
        public int RateYearDayId { get; set; }
        [Required]
        public decimal Rate { get; set; }
        public decimal? IncrementPercent { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        [Required]
        public CarType CarType { get; set; }

        [ForeignKey("Year")]
        public int YearId { get; set; }
        public virtual Year Year { get; set; }

        [ForeignKey("Day")]
        public int DayId { get; set; }
        public virtual Day Day { get; set; }
    }
}
