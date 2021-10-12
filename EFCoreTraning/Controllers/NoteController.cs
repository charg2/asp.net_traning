using EFCoreTraning.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTraning.Controllers
{
    public class NoteController : Controller
    {
        public IActionResult Index()
        {
            using ( var db = new EFCoreDbContext() ) 
            {
                var list = db.Notes.ToList();
                return View( list );
            }
        }


        public IActionResult Add()
        {
            return View();
        }


        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
