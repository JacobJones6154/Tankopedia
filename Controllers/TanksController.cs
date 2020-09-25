using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tankop.Data;
using Tankop.Models;

namespace Tankop.Controllers
{
    public class TanksController : Controller
    {
        private readonly TankopContext _context;

        public TanksController(TankopContext context)
        {
            _context = context;
        }

        // GET: Tanks

        
        public async Task<IActionResult> Index(string tankCountry, string tankClass, int tankTier, string searchString)
        {
            // Use LINQ to get list of countries.
            IQueryable<string> countryQuery = from m in _context.Tanks
                                            orderby m.Country
                                            select m.Country;
            // Use LINQ to get list of classes
            IQueryable<string> classQuery = from c in _context.Tanks
                                            orderby c.Class
                                            select c.Class;
            //Use LINQ to get list of tiers
            IQueryable<int> tierQuery = from t in _context.Tanks
                                        orderby t.Tier
                                        select t.Tier;

            var tank = from m in _context.Tanks
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                tank = tank.Where(s => s.TankName.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(tankCountry))
            {
                tank = tank.Where(x => x.Country == tankCountry);
            }
            if (!string.IsNullOrEmpty(tankClass))
            {
                tank = tank.Where(x => x.Class == tankClass);
            }

          // if (!string.IsNullOrEmpty(tankTier.ToString()))
          // {
          //     tank = tank.Where(x => x.Tier == tankTier);
          // }


            var tankCountryVM = new TankCountryView
            {
               Country = new SelectList(await countryQuery.Distinct().ToListAsync()),
                
               Class = new SelectList(await classQuery.Distinct().ToListAsync()),

              // Tier = new SelectList(await tierQuery.Distinct().ToListAsync()),

               Tanks = await tank.ToListAsync(), 

            };
            return View(tankCountryVM);
        }

        // GET: Tanks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tanks = await _context.Tanks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tanks == null)
            {
                return NotFound();
            }

            return View(tanks);
        }

        // GET: Tanks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tanks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Country,Class,Tier,TankName,HitPoints,ROF,AimTime,Accuracy,AvgPenetration,AvgDamage,Dpm,HullArmor,TurretArmor,ImgSrc")] Tanks tanks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tanks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tanks);
        }

        // GET: Tanks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tanks = await _context.Tanks.FindAsync(id);
            if (tanks == null)
            {
                return NotFound();
            }
            return View(tanks);
        }

        // POST: Tanks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Country,Class,Tier,TankName,HitPoints,ROF,AimTime,Accuracy,AvgPenetration,AvgDamage,Dpm,HullArmor,TurretArmor,ImgSrc")] Tanks tanks)
        {
            if (id != tanks.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tanks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TanksExists(tanks.Id))
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
            return View(tanks);
        }

        // GET: Tanks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tanks = await _context.Tanks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tanks == null)
            {
                return NotFound();
            }

            return View(tanks);
        }

        // POST: Tanks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tanks = await _context.Tanks.FindAsync(id);
            _context.Tanks.Remove(tanks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TanksExists(int id)
        {
            return _context.Tanks.Any(e => e.Id == id);
        }
    }
}
