using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.Models
{
    public class OverviewViewModel
    {

        [DisplayName("Medlem")]
        public string? PersNr { get; set; }

        [DisplayName("Registreringsnummer")]
        public string? RegNbr { get; set; }

        [DisplayName("Färg")]
        public string? Color { get; set; }

        [DisplayName("Märke")]
        public string? Brand { get; set; }

        [DisplayName("Ankomst")]
        public DateTime Arrival { get; set; }

    }
}
