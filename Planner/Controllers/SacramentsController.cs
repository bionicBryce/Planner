using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Planner.Models;

namespace Planner.Controllers
{
    public class SacramentsController : Controller
    {
        private readonly PlannerContext _context;

        public SacramentsController(PlannerContext context)
        {
            _context = context;
        }



        // GET: Sacraments
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public async Task<IActionResult> Index(string sacramentSpeaker, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> speakerQuery = from m in _context.Sacrament
                                              orderby m.Speakers
                                              select m.Speakers;

            var sacraments = from m in _context.Sacrament
                             select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                sacraments = sacraments.Where(s => s.Conducting.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(sacramentSpeaker))
            {
                sacraments = sacraments.Where(x => x.Speakers == sacramentSpeaker);
            }

            var sacramentSpeakerVM = new SacramentSpeakerViewModel();
            sacramentSpeakerVM.speakers = new SelectList(await speakerQuery.Distinct().ToListAsync());
            sacramentSpeakerVM.sacraments = await sacraments.ToListAsync();

            return View(sacramentSpeakerVM);
        }

        // GET: Sacraments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacrament = await _context.Sacrament
                .SingleOrDefaultAsync(m => m.ID == id);
            if (sacrament == null)
            {
                return NotFound();
            }

            return View(sacrament);
        }

        // GET: Sacraments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sacraments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,SacramentDate,Conducting,Hymns,Prayer,Speakers,Subject")] Sacrament sacrament)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sacrament);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sacrament);
        }

        // GET: Sacraments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacrament = await _context.Sacrament.SingleOrDefaultAsync(m => m.ID == id);
            if (sacrament == null)
            {
                return NotFound();
            }
            return View(sacrament);
        }

        // POST: Sacraments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,SacramentDate,Conducting,Hymns,Prayer,Speakers,Subject")] Sacrament sacrament)
        {
            if (id != sacrament.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sacrament);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SacramentExists(sacrament.ID))
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
           
            return View(sacrament);
        }

        // GET: Sacraments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacrament = await _context.Sacrament
                .SingleOrDefaultAsync(m => m.ID == id);
            if (sacrament == null)
            {
                return NotFound();
            }

            return View(sacrament);
        }

        // POST: Sacraments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sacrament = await _context.Sacrament.SingleOrDefaultAsync(m => m.ID == id);
            _context.Sacrament.Remove(sacrament);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
              
        private bool SacramentExists(int id)
        {
            return _context.Sacrament.Any(e => e.ID == id);
        }
    }
}
