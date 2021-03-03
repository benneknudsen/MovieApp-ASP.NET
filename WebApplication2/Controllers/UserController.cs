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
    public class UserController : Controller
    {
        private readonly WebApplication2Context _context;

        public UserController(WebApplication2Context context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }

       

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("userId,userName,firstName,lastName,email,password,birthDate,gender")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("email,password")] User user)
        {
            var test = "false";
            if (ModelState.IsValid)
            {
                var userDb  = from b in _context.User
                              where b.email.Contains(user.email)
                              select b;
                if (userDb != null) {
                    test = "true";
                    ViewData["Message"] = "Your application description page.";
                    return View();
                }
            }
            return View(user);
        }
    }
}
