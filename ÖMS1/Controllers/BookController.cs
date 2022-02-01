
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÖMS1.Controllers
{
    public class BookController : Controller
    {
        BookManager bm = new BookManager(new EfBookRepository());
        public IActionResult BookFind()
        {
            return View();
        }
        public IActionResult BookList()
        {
            var val = bm.GetList();
            return View(val);
        }
    }
}
