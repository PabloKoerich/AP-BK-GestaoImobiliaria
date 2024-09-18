using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoImobiliaria.Web.Models;

namespace GestaoImobiliaria.Web.Controllers
{
    public class CorretoresController : Controller
    {
        private readonly ImobiliariaDbContext _context;

        public CorretoresController(ImobiliariaDbContext context)
        {
            _context = context;
        }

        // GET: Corretores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Corretores.ToListAsync());
        }

        // GET: Corretores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corretores = await _context.Corretores
                .FirstOrDefaultAsync(m => m.CorretorId == id);
            if (corretores == null)
            {
                return NotFound();
            }

            return View(corretores);
        }

        // GET: Corretores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Corretores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CorretorId,Nome,Cpf,Creci,Telefone,Email")] Corretores corretores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(corretores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(corretores);
        }

        // GET: Corretores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corretores = await _context.Corretores.FindAsync(id);
            if (corretores == null)
            {
                return NotFound();
            }
            return View(corretores);
        }

        // POST: Corretores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CorretorId,Nome,Cpf,Creci,Telefone,Email")] Corretores corretores)
        {
            if (id != corretores.CorretorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(corretores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CorretoresExists(corretores.CorretorId))
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
            return View(corretores);
        }

        // GET: Corretores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corretores = await _context.Corretores
                .FirstOrDefaultAsync(m => m.CorretorId == id);
            if (corretores == null)
            {
                return NotFound();
            }

            return View(corretores);
        }

        // POST: Corretores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var corretores = await _context.Corretores.FindAsync(id);
            if (corretores != null)
            {
                _context.Corretores.Remove(corretores);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CorretoresExists(int id)
        {
            return _context.Corretores.Any(e => e.CorretorId == id);
        }
    }
}
