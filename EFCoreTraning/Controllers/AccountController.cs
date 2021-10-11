using EFCoreTraning.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTraning.Controllers
{
    public class AccountController : Controller
    {
        // GET: /controller/
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register( User model )
        {
            if ( ModelState.IsValid )
            {
                using ( var db = new EFCoreDbContext() )
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }

                return RedirectToAction( "Index", "Home" );
            }

            return View(model);
        }
    }
}
