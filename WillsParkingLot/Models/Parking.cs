using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WillsParkingLot.Models
{
    public class Parking
    {
        [Key]
        public int ParkingId { get; set; }
        [Required]
        public DateTime ArriveTime { get; set; }
        public DateTime? LeaveTime { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
    }
}
