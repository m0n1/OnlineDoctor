using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineDoctor.Areas.Doctor.Controllers
{
    public class DoctorController : Controller
    {
        //
        // GET: /Doctor/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Doctor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Doctor/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Doctor/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Doctor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Doctor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Doctor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Doctor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult SearchDoctorByName()
        {
            return View();
        }
        public ActionResult SearchDoctorByArea()
        {
            return View();
        }
        public ActionResult SearchDoctorByChamber()
        {
            return View();
        }
        public ActionResult SearchDoctorByHospital()
        {
            return View();
        }
        public ActionResult SearchDoctorBySpecialization()
        {
            return View();
        }
        public ActionResult SearchDoctorByPopularity()
        {
            return View();
        }
        public ActionResult SearchDoctorByAvailability()
        {
            return View();
        }
        public ActionResult ViewDoctorsProfile()
        {
            return View();
        }
        public ActionResult AddServiceCenter()
        {
            return View();
        }
        public ActionResult UpdateProfile()
        {
            return View();
        }
        public ActionResult AddSchedule()
        {
            return View();
        }
        public ActionResult ApproveAppointment()
        {
            return View();
        }
        public ActionResult ViewAppointmentDetails()
        {
            return View();
        }
        public ActionResult RankDoctor()
        {
            return View();
        }

    }
}
