using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.EDM;

namespace MyProject.Areas.AdminA.Controllers
{
    public class AdminController : Controller
    {
        project_workEntities pe = new project_workEntities();
        // GET: AdminA/Admin

        // Dashboard
        public ActionResult AdminDashboard()
        {
            return View();
        }

        //       Login    //
        public ActionResult Adminlogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adminlogin(FormCollection fc)
        {

            string email = fc["email"];
            string password = fc["password"];
            var data = pe.ADMIN_TABLE.Where(x => x.email_id == email && x.pswrd == password).FirstOrDefault();
            if (data != null)
            {
                Session["Adminid"] = data.admin_id;
                Session["AdminName"] = data.f_name;
                Session["ALastname"] = data.l_name;
                return RedirectToAction("AdminDashboard");
            }
            ViewBag.loginerror = "Invalid Email or Password";
            return View();
        } 

        public ActionResult AdminforgetP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdmitforgetP(ADMIN_TABLE obj)
        {
            pe.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }


        // Appointment   //   
        public ActionResult AppointmentList()
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
            return RedirectToAction("AdminDashboard");
        }


        public ActionResult EditAppointment(int id)
        {
            return View(pe.appointment_table.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAppointment(appointment_table obj)
        {
            pe.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }
        public ActionResult Delete(int id)
        {
            return View(pe.appointment_table.Find(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteR(int id)
        {
            pe.appointment_table.Remove(pe.appointment_table.Find(id));
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }

        //    Doctor  //
        public ActionResult DoctorsList()
        {
            return View(pe.doctors_table.ToList());
        }
        public ActionResult Adddoctor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Adddoctor(doctors_table obj)
        {
            pe.doctors_table.Add(obj);
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }


        public ActionResult Editdocs(int id)
        {
            return View(pe.doctors_table.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editdocs(doctors_table obj)
        {
            pe.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }
        public ActionResult DetailsDoctor(int id)
        {
            return View(pe.doctors_table.Find(id));
        }
        public ActionResult Deletedocs(int id)
        {
            return View(pe.doctors_table.Find(id));
        }
        [HttpPost]
        [ActionName("Deletedocs")]
        public ActionResult DeletedocsR(int id)
        {
            pe.doctors_table.Remove(pe.doctors_table.Find(id));
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }

        // Patient //
        public ActionResult PatientList()
        {
            return View(pe.patient_TABLE.ToList());
        }
        public ActionResult Addpatient()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Addpatient(patient_TABLE obj)
        {
            pe.patient_TABLE.Add(obj);
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }


        public ActionResult Editpatient(int id)
        {
            return View(pe.patient_TABLE.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editpatient(patient_TABLE obj)
        {
            pe.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }
        public ActionResult DetailsPatient(int id)
        {
            return View(pe.patient_TABLE.Find(id));
        }
        public ActionResult Deletepatient(int id)
        {
            return View(pe.patient_TABLE.Find(id));
        }
        [HttpPost]
        [ActionName("Deletepatient")]
        public ActionResult DeletepatientR(int id)
        {
            pe.doctors_table.Remove(pe.doctors_table.Find(id));
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }


        //   Hospital //

        public ActionResult HospitalsList()
        {
            return View(pe.hospital_TABLE.ToList());
        }
        public ActionResult AddHospital()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult AddHospital(hospital_TABLE obj)
        {
            pe.hospital_TABLE.Add(obj);
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }


        public ActionResult EditHospital(int id)
        {
            return View(pe.hospital_TABLE.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditHospital(hospital_TABLE obj)
        {
            pe.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }
        public ActionResult DetailHospital(int id)
        {
            return View(pe.hospital_TABLE.Find(id));
        }
        public ActionResult DeleteHospital(int id)
        {
            return View(pe.hospital_TABLE.Find(id));
        }
        [HttpPost]
        [ActionName("DeleteHospital")]
        public ActionResult DeleteHospitalR(int id)
        {
            pe.hospital_TABLE.Remove(pe.hospital_TABLE.Find(id));
            pe.SaveChanges();
            return RedirectToAction("AdminDashboard");
        }
       
    }
}