using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.EDM;

namespace MyProject.Areas.Doctor.Controllers
{
    public class DoctorsController : Controller
    {
        project_workEntities pe = new project_workEntities();
        // GET: Doctor/Doctors
        public ActionResult DoctorDashboard()
        {
            return View();
        }
        public ActionResult Doctorlogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Doctorlogin(FormCollection fc)
        {
            string email = fc["email"];
            string password = fc["password"];
            var data = pe.doctors_table.Where(x => x.d_gmail == email && x.d_password == password).FirstOrDefault();

            if (data != null)
            {
                Session["DocotrName"] = data.f_name;
                Session["DoctorQ"] = data.qualification;
                Session["Doctorsp"] = data.speciality;
                Session["ProfileImg"]=data.Profile;

                return RedirectToAction("DoctorDashboard");

            }

            ViewBag.loginerror = "Invalid Email or Password";
            return View();
        }
        public ActionResult DoctorRegister()
        {
            return View();
        }
        [HttpPost]

        public ActionResult DoctorRegister(doctors_table obj)
        {
            pe.doctors_table.Add(obj);
            pe.SaveChanges();
            return RedirectToAction("Doctorlogin");
        }
        public ActionResult DoctorAppointment()
        {
            return View(pe.appointment_table.ToList());
        }
        public ActionResult DetailsAppointment()
        {
            return View(pe.appointment_table.ToList());
        }
        public ActionResult DeleteAppointment(int id)
        {
            return View(pe.appointment_table.Find(id));
        }
        [HttpPost]
        [ActionName("DeleteAppointment")]
        public ActionResult DeleteR(int id)
        {
            pe.appointment_table.Remove(pe.appointment_table.Find(id));
            pe.SaveChanges();
            return RedirectToAction("DoctorDashboard");
        }
        public ActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]

        public ActionResult ChangePassword(doctors_table obj)
        {
            pe.doctors_table.Add(obj);
            pe.SaveChanges();
            return RedirectToAction("Doctorlogin");
        }
    }
}