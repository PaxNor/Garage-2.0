using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
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

        [RegularExpression(@"^[A-Z]+[A-Z]+[A-Z]+[0-9]+[0-9]+[0-9]", ErrorMessage = "Registreringsnummret måste börja med 3 stora bokstäver från A till Z och följas av 3 nummer från 0 till 9")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Registreringsnummret måste vara 6 tecken långt!")]
        [DisplayName("Registreringsnummer")]
        //[Remote()]
        public string? RegNbr  { get; set; }

        [DisplayName("Färg")]
        public string? Color { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [DisplayName("Märke")]
        public string? Brand { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [DisplayName("Modell")]
        public string? Model { get; set; }

        [Range(2, 6)]
        [DisplayName("Hjulantal")]
        public int? wheelCount { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Ankomst")]
        public DateTime ParkTime { get; private set; }

        public ParkedVehicle() {
            ParkTime = DateTime.Now;
        }
    }
}
