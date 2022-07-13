using System.ComponentModel;

namespace Garage_2._0.ViewModels
{
    public class StatsViewModel
    {
        [DisplayName("Bilar")]
        public int CarCount { get; set; }
        [DisplayName("Lastbilar")]
        public int TruckCount { get; set; }
        [DisplayName("Båtar")]
        public int BoatCount { get; set; }
        [DisplayName("Bussar")]
        public int BusCount { get; set; }
        [DisplayName("Motorcyklar")]
        public int MotorCycleCount { get; set; }
        [DisplayName("Cyklar")]
        public int BikeCount { get; set; }

        [DisplayName("Totalt antal hjul")]
        public int? TotalWheelCount { get; set; }

        [DisplayName("Totala intäkter")]
        public int TotalGarageIncome { get; set; }

    }
}
