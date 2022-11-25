 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rezercontrols.EDM;

namespace rezercontrols.Controllers
{
    public class DefaultController : Controller
    {
        project_workEntities1 dc=new project_workEntities1();

        // GET: Default
        public ActionResult Index()
        {
            return View(dc.patient_TABLE.ToList());
        }
        void fillstate()
        {
            var data=dc.state_table.ToList();
            List<SelectListItem> li = new List<SelectListItem>();

            foreach (var items in data)
            {
                li.Add ( new SelectListItem
                {
                    Text=items.state_name,
                    Value=items.state_id.ToString()
                });

            }
            ViewBag.states = li;
          
        }
        public ActionResult create()
        {
            fillstate();
            return View();
        }
        [HttpPost]
        public ActionResult create(patient_TABLE obj , FormCollection fc , HttpPostedFileBase profileimg)
        {
            bool Reading =Convert.ToBoolean( fc["Reading"].Split(',')[0]);
            bool Cooking = Convert.ToBoolean( fc["Cooking"].Split(',')[0]);
            bool Writing = Convert.ToBoolean( fc["Writing"].Split(',')[0]);
            bool Singing = Convert.ToBoolean( fc["Singing"].Split(',')[0]);

            string hoby = "";

            if (Reading)
                hoby += "Reading";
            if (Cooking)
                hoby += "Cooking";
            if (Writing)
                hoby += "Writing";
            if (Singing)
                hoby += "Singing"; 

            obj.hobbies = hoby;
            if (profileimg != null)
            {
                string filename=Path.GetFileName(profileimg.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs"),filename);
                profileimg.SaveAs(fullpath);
                obj.profileimg=filename;
            }


            dc.patient_TABLE.Add(obj);
            dc.SaveChanges();

            return View();
        }


    }
}