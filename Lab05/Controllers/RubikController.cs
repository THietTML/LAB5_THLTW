using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab05.Models;

namespace Lab05.Controllers
{
    public class RubikController : Controller
    {
        dbRubikStoreDataContext data = new dbRubikStoreDataContext();
        // GET: Rubik
        public ActionResult Index()
        {
            var all_rubik = from s in data.Rubiks select s;
            return View(all_rubik);
        }
    }
}