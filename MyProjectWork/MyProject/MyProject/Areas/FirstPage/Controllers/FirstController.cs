using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.EDM;

namespace MyProject.Areas.FirstPage.Controllers
{
    public class FirstController : Controller
    {
        // GET: FirstPage/First
        public ActionResult MainDashboard()
        {
            return View();
        }
    }
}