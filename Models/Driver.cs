using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaxiSluzbaBackend.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        public Address Address { get; set; }
        [Required]
        [MaxLength(15)]
        public string Phone { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Vehicle")]
        public int? VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
