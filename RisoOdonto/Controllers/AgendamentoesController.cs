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

    public class AgendamentoesController : Controller
    {
        private readonly RisoOdontoContext _context;

        public AgendamentoesController(RisoOdontoContext context)
        {
            _context = context;
        }

        // GET: Agendamentoes
        public async Task<IActionResult> Index()
        {
            var risoOdontoContext = _context.Agendamento.Include(a => a.Dentista).Include(a => a.Paciente);
            return View(await risoOdontoContext.ToListAsync());
        }

        public IActionResult Agendamento()
        {
            return View();
        }

        // GET: Agendamentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Agendamento == null)
            {
                return NotFound();
            }

            var agendamento = await _context.Agendamento
                .Include(a => a.Dentista)
                .Include(a => a.Paciente)
                .FirstOrDefaultAsync(m => m.IdAgendamento == id);
            if (agendamento == null)
            {
                return NotFound();
            }

            return View(agendamento);
        }

        // GET: Agendamentoes/Create
        public IActionResult Create()
        {
            ViewData["DentistaId"] = new SelectList(_context.Dentista, "IdDentista", "Email");
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "Id", "CPF");
            return View();
        }

        // POST: Agendamentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAgendamento,Data_Consulta,Horario,Primeira_Consulta,Status_Consulta,PacienteId,DentistaId")] Agendamento agendamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agendamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DentistaId"] = new SelectList(_context.Dentista, "IdDentista", "Email", agendamento.DentistaId);
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "Id", "CPF", agendamento.PacienteId);
            return View(agendamento);
        }

        // GET: Agendamentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Agendamento == null)
            {
                return NotFound();
            }

            var agendamento = await _context.Agendamento.FindAsync(id);
            if (agendamento == null)
            {
                return NotFound();
            }
            ViewData["DentistaId"] = new SelectList(_context.Dentista, "IdDentista", "Email", agendamento.DentistaId);
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "Id", "CPF", agendamento.PacienteId);
            return View(agendamento);
        }

        // POST: Agendamentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAgendamento,Data_Consulta,Horario,Primeira_Consulta,Status_Consulta,PacienteId,DentistaId")] Agendamento agendamento)
        {
            if (id != agendamento.IdAgendamento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agendamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgendamentoExists(agendamento.IdAgendamento))
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
            ViewData["DentistaId"] = new SelectList(_context.Dentista, "IdDentista", "Email", agendamento.DentistaId);
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "Id", "CPF", agendamento.PacienteId);
            return View(agendamento);
        }

        // GET: Agendamentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Agendamento == null)
            {
                return NotFound();
            }

            var agendamento = await _context.Agendamento
                .Include(a => a.Dentista)
                .Include(a => a.Paciente)
                .FirstOrDefaultAsync(m => m.IdAgendamento == id);
            if (agendamento == null)
            {
                return NotFound();
            }

            return View(agendamento);
        }

        // POST: Agendamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Agendamento == null)
            {
                return Problem("Entity set 'RisoOdontoContext.Agendamento'  is null.");
            }
            var agendamento = await _context.Agendamento.FindAsync(id);
            if (agendamento != null)
            {
                _context.Agendamento.Remove(agendamento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgendamentoExists(int id)
        {
          return (_context.Agendamento?.Any(e => e.IdAgendamento == id)).GetValueOrDefault();
        }
    }
}
