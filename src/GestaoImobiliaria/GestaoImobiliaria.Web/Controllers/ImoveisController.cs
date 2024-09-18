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
    public class ImoveisController : Controller
    {
        private readonly ImobiliariaDbContext _context;

        public ImoveisController(ImobiliariaDbContext context)
        {
            _context = context;
        }

        // GET: Imoveis
        public async Task<IActionResult> Index()
        {
            var imobiliariaDbContext = _context.Imoveis.Include(i => i.ClienteDono).Include(i => i.CorretorGestor).Include(i => i.CorretorNegocio);
            return View(await imobiliariaDbContext.ToListAsync());
        }

        // GET: Imoveis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imoveis = await _context.Imoveis
                .Include(i => i.ClienteDono)
                .Include(i => i.CorretorGestor)
                .Include(i => i.CorretorNegocio)
                .FirstOrDefaultAsync(m => m.ImovelId == id);
            if (imoveis == null)
            {
                return NotFound();
            }

            return View(imoveis);
        }

        // GET: Imoveis/Create
        public IActionResult Create()
        {
            ViewData["ClienteDonoId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId");
            ViewData["CorretorGestorId"] = new SelectList(_context.Corretores, "CorretorId", "CorretorId");
            ViewData["CorretorNegocioId"] = new SelectList(_context.Corretores, "CorretorId", "CorretorId");
            return View();
        }

        // POST: Imoveis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImovelId,Endereco,Tipo,Area,Valor,Descricao,Negocio,CorretorNegocioId,CorretorGestorId,ClienteDonoId,Disponivel,Fotos")] Imoveis imoveis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imoveis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteDonoId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", imoveis.ClienteDonoId);
            ViewData["CorretorGestorId"] = new SelectList(_context.Corretores, "CorretorId", "CorretorId", imoveis.CorretorGestorId);
            ViewData["CorretorNegocioId"] = new SelectList(_context.Corretores, "CorretorId", "CorretorId", imoveis.CorretorNegocioId);
            return View(imoveis);
        }

        // GET: Imoveis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imoveis = await _context.Imoveis.FindAsync(id);
            if (imoveis == null)
            {
                return NotFound();
            }
            ViewData["ClienteDonoId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", imoveis.ClienteDonoId);
            ViewData["CorretorGestorId"] = new SelectList(_context.Corretores, "CorretorId", "CorretorId", imoveis.CorretorGestorId);
            ViewData["CorretorNegocioId"] = new SelectList(_context.Corretores, "CorretorId", "CorretorId", imoveis.CorretorNegocioId);
            return View(imoveis);
        }

        // POST: Imoveis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImovelId,Endereco,Tipo,Area,Valor,Descricao,Negocio,CorretorNegocioId,CorretorGestorId,ClienteDonoId,Disponivel,Fotos")] Imoveis imoveis)
        {
            if (id != imoveis.ImovelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imoveis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImoveisExists(imoveis.ImovelId))
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
            ViewData["ClienteDonoId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", imoveis.ClienteDonoId);
            ViewData["CorretorGestorId"] = new SelectList(_context.Corretores, "CorretorId", "CorretorId", imoveis.CorretorGestorId);
            ViewData["CorretorNegocioId"] = new SelectList(_context.Corretores, "CorretorId", "CorretorId", imoveis.CorretorNegocioId);
            return View(imoveis);
        }

        // GET: Imoveis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imoveis = await _context.Imoveis
                .Include(i => i.ClienteDono)
                .Include(i => i.CorretorGestor)
                .Include(i => i.CorretorNegocio)
                .FirstOrDefaultAsync(m => m.ImovelId == id);
            if (imoveis == null)
            {
                return NotFound();
            }

            return View(imoveis);
        }

        // POST: Imoveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imoveis = await _context.Imoveis.FindAsync(id);
            if (imoveis != null)
            {
                _context.Imoveis.Remove(imoveis);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImoveisExists(int id)
        {
            return _context.Imoveis.Any(e => e.ImovelId == id);
        }
    }
}
