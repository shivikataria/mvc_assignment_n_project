using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajaxcrud.EDM;

namespace Ajaxcrud.Controllers
{
    public class masterController : Controller
    {
        companyEntities dc = new companyEntities();
        // GET: master
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetEmployee()
        {
            dc.Configuration.ProxyCreationEnabled = false;
            return Json(dc.employees.ToList(),JsonRequestBehavior.AllowGet) ;
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public string Create(employee obj)
        {
            dc.employees.Add(obj);
            dc.SaveChanges();
            return "Record Inserted.";
        }

        public ActionResult Edit(int id)
        {
            return View(dc.employees.Find(id));
        }
        [HttpPost]
        public string Edit(employee obj)
        {
            dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();
            return "Record Updated.";
        }

        public ActionResult Delete(int id)
        {
            return View(dc.employees.Find(id));
        }
        [HttpPost, ActionName("Delete")]
        public string DeleteRec(int id)
        {
            dc.employees.Remove(dc.employees.Find(id));
            dc.SaveChanges();
            return "Record Deleted.";
        }
    }
}