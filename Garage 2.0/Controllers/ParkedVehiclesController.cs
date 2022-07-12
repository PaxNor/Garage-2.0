using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garage_2._0.Data;
using Garage_2._0.Models;
using Garage_2._0.ViewModels;

namespace Garage_2._0.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        private readonly Garage_2_0Context _context;

        public ParkedVehiclesController(Garage_2_0Context context)
        {
            ArgumentNullException.ThrowIfNull(context);
            _context = context;
        }

        //public async Task<IActionResult> Filter(IndexViewModel indexViewModel)
        //{
        //    var parkedVehicles = string.IsNullOrWhiteSpace(indexViewModel.RegNbr) ?
        //        _context.ParkedVehicle :
        //        _context.ParkedVehicle.Where(v => v.RegNbr!.StartsWith(indexViewModel.RegNbr));

        //        parkedVehicles = indexViewModel.VehicleType == null ?
        //        parkedVehicles :
        //        parkedVehicles.Where(v => v.Type == indexViewModel.VehicleType);

        //    var model = new IndexViewModel
        //    {
        //        ParkedVehicles = await parkedVehicles.ToListAsync()

        //    };
        //    return View(nameof(Index), model);
        //}

        public async Task<IActionResult> Filter(OverviewViewModel overviewViewModel)
        {
            var parkedVehicles = string.IsNullOrWhiteSpace(overviewViewModel.RegNbr) ?
                _context.ParkedVehicle :
                _context.ParkedVehicle.Where(v => v.RegNbr!.StartsWith(overviewViewModel.RegNbr));

            parkedVehicles = overviewViewModel.VehicleType == null ?
            parkedVehicles :
            parkedVehicles.Where(v => v.Type == overviewViewModel.VehicleType);

            var model = new OverviewViewModel
            {
                ParkedVehicles = await parkedVehicles.ToListAsync()

            };
            return View(nameof(Overview), model);
        }


        // GET: ParkedVehicles
        public async Task<IActionResult> Index()
        {
            var model = new IndexViewModel()
            {
                ParkedVehicles = await _context.ParkedVehicle.ToListAsync()
            };
            return View(model);
        }

        public async Task<IActionResult> Overview()
        {

            var model = new OverviewViewModel()
            {
                ParkedVehicles = await _context.ParkedVehicle.ToListAsync()
            };
            return View(model);
        }

        // GET: ParkedVehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ParkedVehicle == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }

            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Create
        public IActionResult Checkin()
        {
            return View();
        }

        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkin([Bind("Id,Type,RegNbr,Color,Brand,Model,wheelCount,ParkTime")] ParkedVehicle parkedVehicle)
        {
            // Reg number check
            foreach (var vehicle in _context.ParkedVehicle) {
                if (parkedVehicle.RegNbr == vehicle.RegNbr) {
                    ModelState.AddModelError("RegNbr", "Fordonet finns redan parkerat i garaget.");
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(parkedVehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ParkedVehicle == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle.FindAsync(id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,RegNbr,Color,Brand,Model,wheelCount,ParkTime")] ParkedVehicle parkedVehicle)
        {
            if (id != parkedVehicle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parkedVehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkedVehicleExists(parkedVehicle.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Delete/5
        public async Task<IActionResult> Checkout(int? id)
        {
            if (id == null || _context.ParkedVehicle == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }

            return View(parkedVehicle);
        }

        public IActionResult Receipt(ReceiptViewModel vm) {
            return View(vm);
        }

        // POST: ParkedVehicles/Delete/5
        [HttpPost, ActionName("Checkout")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ParkedVehicle == null)
            {
                return Problem("Entity set 'Garage_2_0Context.ParkedVehicle'  is null.");
            }
            var parkedVehicle = await _context.ParkedVehicle.FindAsync(id);
            if (parkedVehicle != null) {
                _context.ParkedVehicle.Remove(parkedVehicle);
                await _context.SaveChangesAsync();
            }
            else
                return NotFound();
          
            var receipt = new ReceiptViewModel(parkedVehicle.ParkTime,
                                               parkedVehicle.RegNbr!,
                                               parkedVehicle.Color!,
                                               parkedVehicle.Brand!);

            return View("Receipt", receipt);
        }

        private bool ParkedVehicleExists(int id)
        {
          return (_context.ParkedVehicle?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
