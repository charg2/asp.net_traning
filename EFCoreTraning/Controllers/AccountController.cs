using EFCoreTraning.Models;
using EFCoreTraning.ViewModels;
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

        [HttpPost]
        public IActionResult Login( LoginViewModel model )
        {
            if ( ModelState.IsValid )
            {
                using ( var db = new EFCoreDbContext() )
                {
                    // Linq 메서드 체이닝
                    var user = db.Users.FirstOrDefault( 
                        u => u.UserId.Equals( model.UserId ) && 
                             u.UserPassword.Equals( model.UserPassword ) );
                    
                    if( null != user )
                    {
                        return RedirectToAction( "LoginSuccess", "Home" );
                    }
                }

                ModelState.AddModelError( string.Empty, "사용자 ID 혹은 비밀번호가 올바르지 않습니다." );
            }

            return View( model );
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
