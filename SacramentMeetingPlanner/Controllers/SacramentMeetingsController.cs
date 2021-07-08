using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Controllers
{
    public class SacramentMeetingsController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public SacramentMeetingsController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: SacramentMeetings
        public async Task<IActionResult> Index()
        {
            return View(await _context.SacramentMeeting.ToListAsync());
        }

        // GET: SacramentMeetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeeting
                .FirstOrDefaultAsync(m => m.SacramentMeetingId == id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }

            return View(sacramentMeeting);
        }

        // GET: SacramentMeetings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SacramentMeetings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SacramentMeetingId,DateOfMeeting,ConductLeader,OpenHymn,CloseHymn,SacramentHymn,OpenPrayer,ClosePrayer,MusicalNumber")] SacramentMeeting sacramentMeeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sacramentMeeting);
                await _context.SaveChangesAsync();

                // (action, controller, newSacramentMeetingId)
                // https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction?view=aspnetcore-5.0#Microsoft_AspNetCore_Mvc_ControllerBase_RedirectToAction_System_String_System_String_System_String_
                Debug.WriteLine("This is the meeting id"); // why it is not showing in any place?
                Debug.WriteLine(sacramentMeeting.SacramentMeetingId);
                return RedirectToAction("Index", "Speakers", new { id = sacramentMeeting.SacramentMeetingId }); 
            }
            return View(sacramentMeeting);
        }

        // GET: SacramentMeetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeeting.FindAsync(id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }
            return View(sacramentMeeting);
        }

        // POST: SacramentMeetings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SacramentMeetingId,DateOfMeeting,ConductLeader,OpenHymn,CloseHymn,SacramentHymn,OpenPrayer,ClosePrayer,MusicalNumber")] SacramentMeeting sacramentMeeting)
        {
            if (id != sacramentMeeting.SacramentMeetingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sacramentMeeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SacramentMeetingExists(sacramentMeeting.SacramentMeetingId))
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
            return View(sacramentMeeting);
        }

        // GET: SacramentMeetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeeting
                .FirstOrDefaultAsync(m => m.SacramentMeetingId == id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }

            return View(sacramentMeeting);
        }

        // POST: SacramentMeetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sacramentMeeting = await _context.SacramentMeeting.FindAsync(id);
            _context.SacramentMeeting.Remove(sacramentMeeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SacramentMeetingExists(int id)
        {
            return _context.SacramentMeeting.Any(e => e.SacramentMeetingId == id);
        }
    }
}
