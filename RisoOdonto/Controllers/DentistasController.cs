using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RisoOdonto.Data;
using RisoOdonto.Models;

namespace RisoOdonto.Controllers
{
    public class DentistasController : Controller
    {
        private readonly RisoOdontoContext _context;

        public DentistasController(RisoOdontoContext context)
        {
            _context = context;
        }

        // GET: Dentistas
        public async Task<IActionResult> Index()
        {
              return _context.Dentista != null ? 
                          View(await _context.Dentista.ToListAsync()) :
                          Problem("Entity set 'RisoOdontoContext.Dentista'  is null.");
        }

        // GET: Dentistas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Dentista == null)
            {
                return NotFound();
            }

            var dentista = await _context.Dentista
                .FirstOrDefaultAsync(m => m.IdDentista == id);
            if (dentista == null)
            {
                return NotFound();
            }

            return View(dentista);
        }

        // GET: Dentistas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dentistas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDentista,Nome,Email,Login_Dentista,Senha,Especialidade")] Dentista dentista)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dentista);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dentista);
        }

        // GET: Dentistas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Dentista == null)
            {
                return NotFound();
            }

            var dentista = await _context.Dentista.FindAsync(id);
            if (dentista == null)
            {
                return NotFound();
            }
            return View(dentista);
        }

        // POST: Dentistas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDentista,Nome,Email,Login_Dentista,Senha,Especialidade")] Dentista dentista)
        {
            if (id != dentista.IdDentista)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dentista);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DentistaExists(dentista.IdDentista))
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
            return View(dentista);
        }

        // GET: Dentistas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dentista == null)
            {
                return NotFound();
            }

            var dentista = await _context.Dentista
                .FirstOrDefaultAsync(m => m.IdDentista == id);
            if (dentista == null)
            {
                return NotFound();
            }

            return View(dentista);
        }

        // POST: Dentistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dentista == null)
            {
                return Problem("Entity set 'RisoOdontoContext.Dentista'  is null.");
            }
            var dentista = await _context.Dentista.FindAsync(id);
            if (dentista != null)
            {
                _context.Dentista.Remove(dentista);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DentistaExists(int id)
        {
          return (_context.Dentista?.Any(e => e.IdDentista == id)).GetValueOrDefault();
        }
    }
}
