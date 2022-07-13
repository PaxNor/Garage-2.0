using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.Models
{
    public class OverviewViewModel
    {
        public int Id { get; set; }
        public IEnumerable<ParkedVehicle> ParkedVehicles { get; set; } = new List<ParkedVehicle>();
        public IEnumerable<SelectListItem> VehicleTypes { get; set; } = new List<SelectListItem>();

        [Required]
        [DisplayName("Registreringsnummer")]
        public string? RegNbr { get; set; }

        [Required]
        [DisplayName("Fordonstyp")]
        public VehicleTypes? VehicleType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Ankomst")]
        public DateTime ParkTime { get; set; }

        [Required]
        [DisplayName("Antal timmar parkerade")]
        public double ParkedTime  { get; set; }

    }
}
