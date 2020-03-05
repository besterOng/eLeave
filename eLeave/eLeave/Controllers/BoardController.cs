using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLeave.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ApplyLeave()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}