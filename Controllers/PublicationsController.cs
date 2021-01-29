using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Book_MVC.Data;
using Book_MVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace Book_MVC.Controllers
{
    public class PublicationsController : Controller
    {
        private readonly Book_MVCDatabase _context;

        public PublicationsController(Book_MVCDatabase context)
        {
            _context = context;
        }

        // GET: Publications
        public async Task<IActionResult> Index()
        {
            var book_MVCDatabase = _context.Publications.Include(p => p.Books_detail).Include(p => p.Publisher_detail);
            return View(await book_MVCDatabase.ToListAsync());
        }

        // GET: Publications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publications = await _context.Publications
                .Include(p => p.Books_detail)
                .Include(p => p.Publisher_detail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (publications == null)
            {
                return NotFound();
            }

            return View(publications);
        }
        [Authorize]
        // GET: Publications/Create
        public IActionResult Create()
        {
            ViewData["Books_detailId"] = new SelectList(_context.Books, "Id", "Tittle");
            ViewData["Publisher_detailId"] = new SelectList(_context.Publisher, "Id", "Publisher_Name");
            return View();
        }

        // POST: Publications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Books_Copies,Publisher_detailId,Books_detailId")] Publications publications)
        {
            if (ModelState.IsValid)
            {
                _context.Add(publications);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Books_detailId"] = new SelectList(_context.Books, "Id", "Tittle", publications.Books_detailId);
            ViewData["Publisher_detailId"] = new SelectList(_context.Publisher, "Id", "Publisher_Name", publications.Publisher_detailId);
            return View(publications);
        }
        [Authorize]
        // GET: Publications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publications = await _context.Publications.FindAsync(id);
            if (publications == null)
            {
                return NotFound();
            }
            ViewData["Books_detailId"] = new SelectList(_context.Books, "Id", "Tittle", publications.Books_detailId);
            ViewData["Publisher_detailId"] = new SelectList(_context.Publisher, "Id", "Publisher_Name", publications.Publisher_detailId);
            return View(publications);
        }

        // POST: Publications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Books_Copies,Publisher_detailId,Books_detailId")] Publications publications)
        {
            if (id != publications.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(publications);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublicationsExists(publications.Id))
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
            ViewData["Books_detailId"] = new SelectList(_context.Books, "Id", "Tittle", publications.Books_detailId);
            ViewData["Publisher_detailId"] = new SelectList(_context.Publisher, "Id", "Publisher_Name", publications.Publisher_detailId);
            return View(publications);
        }
        [Authorize]
        // GET: Publications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publications = await _context.Publications
                .Include(p => p.Books_detail)
                .Include(p => p.Publisher_detail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (publications == null)
            {
                return NotFound();
            }

            return View(publications);
        }

        // POST: Publications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publications = await _context.Publications.FindAsync(id);
            _context.Publications.Remove(publications);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PublicationsExists(int id)
        {
            return _context.Publications.Any(e => e.Id == id);
        }
    }
}
