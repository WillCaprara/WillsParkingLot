using System.ComponentModel.DataAnnotations;
using WillsParkingLot.Enums;

namespace WillsParkingLot.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        public string LicensePlate { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Color { get; set; }
        public CarType Type { get; set; }
    }
}
