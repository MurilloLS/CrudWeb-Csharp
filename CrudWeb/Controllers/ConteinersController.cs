using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudWeb.Data;
using CrudWeb.Models;

namespace CrudWeb.Controllers
{
    public class ConteinersController : Controller
    {
        private readonly Contexto _context;

        public ConteinersController(Contexto context)
        {
            _context = context;
        }

        // GET: Conteiners
        public async Task<IActionResult> Index()
        {
              return _context.Conteiner != null ? 
                          View(await _context.Conteiner.ToListAsync()) :
                          Problem("Entity set 'Contexto.Conteiner'  is null.");
        }

        // GET: Conteiners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Conteiner == null)
            {
                return NotFound();
            }

            var conteiner = await _context.Conteiner
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conteiner == null)
            {
                return NotFound();
            }

            return View(conteiner);
        }

        // GET: Conteiners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Conteiners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cliente,Numero,Tipo,Status,Categoria")] Conteiner conteiner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conteiner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(conteiner);
        }

        // GET: Conteiners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Conteiner == null)
            {
                return NotFound();
            }

            var conteiner = await _context.Conteiner.FindAsync(id);
            if (conteiner == null)
            {
                return NotFound();
            }
            return View(conteiner);
        }

        // POST: Conteiners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cliente,Numero,Tipo,Status,Categoria")] Conteiner conteiner)
        {
            if (id != conteiner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conteiner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConteinerExists(conteiner.Id))
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
            return View(conteiner);
        }

        // GET: Conteiners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Conteiner == null)
            {
                return NotFound();
            }

            var conteiner = await _context.Conteiner
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conteiner == null)
            {
                return NotFound();
            }

            return View(conteiner);
        }

        // POST: Conteiners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Conteiner == null)
            {
                return Problem("Entity set 'Contexto.Conteiner'  is null.");
            }
            var conteiner = await _context.Conteiner.FindAsync(id);
            if (conteiner != null)
            {
                _context.Conteiner.Remove(conteiner);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConteinerExists(int id)
        {
          return (_context.Conteiner?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
