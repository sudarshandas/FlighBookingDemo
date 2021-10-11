using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoComplete.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index(string id)
        {
            return View();
        }
    }
}