using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Garage_2._0.Models
{
    public class  ParkedVehicle
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Fordonstyp")]
        public VehicleTypes? Type { get; set; }

        [DisplayName("Registreringsnummer")]
        public string? RegNbr  { get; set; }

        [DisplayName("Färg")]
        public string? Color { get; set; }

        [DisplayName("Märke")]
        public string? Brand { get; set; }

        [DisplayName("Modell")]
        public string? Model { get; set; }

        [Range(2, 6)]
        [DisplayName("Hjulantal")]
        public int? wheelCount { get; set; }

        [DisplayName("Ankomst")]
        public DateTime ParkTime { get; private set; }

        public ParkedVehicle() {
            ParkTime = DateTime.Now;
        }
    }
}
