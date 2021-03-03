using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

namespace WebApplication2.Models
{
    public class UserMovieController : Controller
    {
        private readonly WebApplication2Context _context;

        public UserMovieController(WebApplication2Context context)
        {
            _context = context;
        }

        // GET: UserMovie
        public async Task<IActionResult> Index()
        {
            var webApplication2Context = _context.UserMovie.Include(u => u.Movie).Include(u => u.User);
            return View(await webApplication2Context.ToListAsync());
        }

        // GET: UserMovie/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMovie = await _context.UserMovie
                .Include(u => u.Movie)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.userMovieId == id);
            if (userMovie == null)
            {
                return NotFound();
            }

            return View(userMovie);
        }

        // GET: UserMovie/Create
        public IActionResult Create()
        {
            ViewData["movieId"] = new SelectList(_context.Movie, "movieId", "movieId");
            ViewData["userId"] = new SelectList(_context.User, "userId", "userId");
            return View();
        }

        // POST: UserMovie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("userMovieId,movieId,userId")] UserMovie userMovie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userMovie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["movieId"] = new SelectList(_context.Movie, "movieId", "movieId", userMovie.movieId);
            ViewData["userId"] = new SelectList(_context.User, "userId", "userId", userMovie.userId);
            return View(userMovie);
        }

        // GET: UserMovie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMovie = await _context.UserMovie.FindAsync(id);
            if (userMovie == null)
            {
                return NotFound();
            }
            ViewData["movieId"] = new SelectList(_context.Movie, "movieId", "movieId", userMovie.movieId);
            ViewData["userId"] = new SelectList(_context.User, "userId", "userId", userMovie.userId);
            return View(userMovie);
        }

        // POST: UserMovie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("userMovieId,movieId,userId")] UserMovie userMovie)
        {
            if (id != userMovie.userMovieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userMovie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserMovieExists(userMovie.userMovieId))
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
            ViewData["movieId"] = new SelectList(_context.Movie, "movieId", "movieId", userMovie.movieId);
            ViewData["userId"] = new SelectList(_context.User, "userId", "userId", userMovie.userId);
            return View(userMovie);
        }

        // GET: UserMovie/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMovie = await _context.UserMovie
                .Include(u => u.Movie)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.userMovieId == id);
            if (userMovie == null)
            {
                return NotFound();
            }

            return View(userMovie);
        }

        // POST: UserMovie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userMovie = await _context.UserMovie.FindAsync(id);
            _context.UserMovie.Remove(userMovie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserMovieExists(int id)
        {
            return _context.UserMovie.Any(e => e.userMovieId == id);
        }
    }
}
