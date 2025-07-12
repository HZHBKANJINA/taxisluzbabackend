using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaxiSluzbaBackend.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        [Required]
        [MaxLength(50)]
        public string VehicleBrand { get; set; }
        [Required]
        [MaxLength(50)]
        public string VehicleModel { get; set; }
        [Required]
        [MaxLength(10)]
        public string LicenseNumber { get; set; }
    }
}
