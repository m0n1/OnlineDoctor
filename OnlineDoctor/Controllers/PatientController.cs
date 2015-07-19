﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineDoctor.Controllers
{
    public class PatientController : Controller
    {
        //
        // GET: /Patient/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Patient/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Patient/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Patient/Create
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
        // GET: /Patient/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Patient/Edit/5
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
        // GET: /Patient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Patient/Delete/5
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

        public ActionResult UpdateProfile()
        {
            return View();
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
        public ActionResult CreateAppointment()
        {
            return View();
        }
        public ActionResult AddPrescription()
        {
            return View();
        }
        public ActionResult CreateNewConsecuitveAppointment()
        {
            return View();
        }
        public ActionResult CommentDoctor()
        {
            return View();
        }
        public ActionResult RankDoctor()
        {
            return View();
        }
        public ActionResult ViewAppointmentDetails()
        {
            return View();
        }
        public ActionResult ViewDoctorsProfile()
        {
            return View();
        }
    }
}
