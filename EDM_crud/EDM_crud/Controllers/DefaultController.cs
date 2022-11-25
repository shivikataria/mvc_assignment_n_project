using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Async;
using System.Web.Profile;
using System.Web.Routing;
using EDM_crud.edm;

namespace EDM_crud.Controllers
{
    public class DefaultController : Controller
    {
        companyEntities ce = new companyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(ce.employees.ToList());
        }
        public ActionResult Details(int id)
        {
            return View(ce.employees.Find(id));
        }
        public ActionResult Addemp()
        {
            return View();
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Addemp(employee obj)
        {
            ce.employees.Add(obj);
            ce.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Editemp(int id)
        {
            return View(ce.employees.Find(id));
        }
        [HttpPost]
        public ActionResult Editemp(employee obj)
        {
            ce.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            ce.SaveChanges();
            return RedirectToAction("Index");
        }
       public ActionResult Delete(int id)
        {
            return View(ce.employees.Find(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteR(int id)
        {
            ce.employees.Remove(ce.employees.Find(id));
            ce.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}