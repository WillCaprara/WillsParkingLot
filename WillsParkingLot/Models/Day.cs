using System.ComponentModel.DataAnnotations;

namespace WillsParkingLot.Models
{
    public class Day
    {
        [Key]
        public int DayId { get; set; }
        public string DayName { get; set; }
    }
}
