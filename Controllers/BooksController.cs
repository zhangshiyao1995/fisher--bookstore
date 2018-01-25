using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController: Controller
    {
        public IActionResult Index()
        {
            return Content ("Books Index");
        }

        public IActionResult Featured()
        {
            return Content ("Books New");
        }

    }
}