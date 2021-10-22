using System.ComponentModel.DataAnnotations;

namespace WillsParkingLot.Models
{
    public class Year
    {
        [Key]
        public int YearId { get; set; }
        public int YearNumber { get; set; }
    }
}
