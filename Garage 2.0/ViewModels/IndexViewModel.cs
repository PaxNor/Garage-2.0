using Garage_2._0.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Garage_2._0.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<ParkedVehicle> ParkedVehicles { get; set; } = new List<ParkedVehicle>();

        public IEnumerable<SelectListItem> VehicleTypes { get; set; } = new List<SelectListItem>();

        public string RegNbr { get; set; }

        public VehicleTypes VehicleType { get; set; }
    }
}
