using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.ViewModels
{
    public class ReceiptViewModel
    {
        [DisplayName("Registreringsnummer")]
        public string? RegNbr { get; set; }

        [DisplayName("Färg")]
        public string? Color { get; set; }

        [DisplayName("Märke")]
        public string? Brand { get; set; }

        [DisplayName("Ankomst")]
        public DateTime Arrival { get; private set; }

        [DisplayName("Avresa")]
        public DateTime Departure { get; private set; }

        [DisplayName("Parkerad tid")]
        public double ElapsedTime { get; private set; }

        public ReceiptViewModel(DateTime arrival, string regNbr, string color, string brand) {
            Arrival = arrival;
            Departure = DateTime.Now;
            RegNbr = regNbr;
            Color = color;
            Brand = brand;
        }

    }
}
