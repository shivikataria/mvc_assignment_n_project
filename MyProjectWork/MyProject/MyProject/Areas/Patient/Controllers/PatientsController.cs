using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.EDM;

namespace MyProject.Areas.Patient.Controllers
{
    public class PatientsController : Controller
    {
        project_workEntities pe = new project_workEntities();
        // GET: Patient/Patients
        public ActionResult PatientDashboard()
        {
            return View();
        }
        public ActionResult Patientlogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Patientlogin(FormCollection fc)
        {
            string email = fc["email"];
            string password = fc["password"];
            var data = pe.patient_TABLE.Where(x => x.email_id == email && x.pswrd == password).FirstOrDefault();

            if (data != null)
            {
                Session["FirstName"] = data.f_name;
                Session["LAST"] = data.l_name;
                Session["DOB"] = data.DOB;
                Session["ProfileImg"] = data.profileimg;
                Session["Address"] = data.p_address;

                return RedirectToAction("PatientDashboard");

            }

            ViewBag.loginerror = "Invalid Email or Password";
            return View();
        }
        public ActionResult PatientRegister()
        {
            return View();
        }
        [HttpPost]

        public ActionResult PatientRegister(patient_TABLE obj)
        {
            pe.patient_TABLE.Add(obj);
            pe.SaveChanges();
            return RedirectToAction("Patientlogin");
        }
        public ActionResult ListAppointment()
        {
            return View(pe.appointment_table.ToList());
        }
        public ActionResult AddAppointment()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult AddAppointment(appointment_table obj)
        {
            pe.appointment_table.Add(obj);
            pe.SaveChanges();
            return RedirectToAction("ListAppointment");
        }

        public ActionResult BookAppointment()
        {
            return View(pe.appointment_table.ToList());
        }

    } 
}