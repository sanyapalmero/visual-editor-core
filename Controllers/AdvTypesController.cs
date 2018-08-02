using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreEditor.Models;

namespace CoreEditor.Controllers
{
    public class AdvTypesController : Controller
    {
        private readonly CoreEditorContext _context;

        public AdvTypesController(CoreEditorContext context)
        {
            _context = context;
        }

        // GET: AdvTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdvTypes.ToListAsync());
        }

        // GET: AdvTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advType = await _context.AdvTypes
                .SingleOrDefaultAsync(m => m.ID == id);
            if (advType == null)
            {
                return NotFound();
            }

            return View(advType);
        }

        // GET: AdvTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdvTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TypeName,TypeSize,TypePrice")] AdvType advType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(advType);
        }

        // GET: AdvTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advType = await _context.AdvTypes.SingleOrDefaultAsync(m => m.ID == id);
            if (advType == null)
            {
                return NotFound();
            }
            return View(advType);
        }

        // POST: AdvTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TypeName,TypeSize,TypePrice")] AdvType advType)
        {
            if (id != advType.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvTypeExists(advType.ID))
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
            return View(advType);
        }

        // GET: AdvTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advType = await _context.AdvTypes
                .SingleOrDefaultAsync(m => m.ID == id);
            if (advType == null)
            {
                return NotFound();
            }

            return View(advType);
        }

        // POST: AdvTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var advType = await _context.AdvTypes.SingleOrDefaultAsync(m => m.ID == id);
            _context.AdvTypes.Remove(advType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvTypeExists(int id)
        {
            return _context.AdvTypes.Any(e => e.ID == id);
        }
    }
}
