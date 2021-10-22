using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WillsParkingLot.Models
{
    public class ParkingFee
    {
        [Key]
        public int ParkingFeeId { get; set; }

        public decimal TotalParkingFeeCollected { get; set; }

        [ForeignKey("Parking")]
        public int ParkingId { get; set; }
        public virtual Parking Parking { get; set; }
    }
}
