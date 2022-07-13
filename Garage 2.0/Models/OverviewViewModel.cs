using Microsoft.AspNetCore.Mvc.Rendering;

namespace Garage_2._0.Models
{
    public class OverviewViewModel
    {
        public int Id { get; set; }
        public IEnumerable<ParkedVehicle> ParkedVehicles { get; set; } = new List<ParkedVehicle>();
        public IEnumerable<SelectListItem> VehicleTypes { get; set; } = new List<SelectListItem>();
        public string? RegNbr { get; set; }
        public VehicleTypes? VehicleType { get; set; }

        public DateTime ParkTime { get; set; }
        public double ParkedTime  { get; set; }

    }
}
