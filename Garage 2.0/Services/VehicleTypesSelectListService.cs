using Garage_2._0.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Garage_2._0.Services
{
    public class VehicleTypesSelectListService : IVehicleTypesSelectListService
    {
        private readonly Garage_3_Context _context;

        public VehicleTypesSelectListService(Garage_3_Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetVehicleTypesAsync()
        {
            return await _context.Vehicle
                .Select(v => v.VehicleType)
                .Distinct()
                .Select(v => new SelectListItem
                {
                    Text = v.ToString(),
                    Value = v.ToString()
                })
                .ToListAsync();
        }
    }
}
