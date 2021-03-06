﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class ProgramsController : Controller
    {
        // GET: Programs
        public ActionResult Index()
        {
            ViewBag.HeroText = "";
            ViewBag.BodyHeaderText = "";

            ViewBag.SideHeader = "";
            ViewBag.SideSubHeader1 = "";
            ViewBag.SideSubText1 = "";
            ViewBag.SideSubHeader2 = "";
            ViewBag.SideSubText2 = "";
            ViewBag.SideSubHeader3 = "";
            ViewBag.SideSubText3 = "";

            return View();
        }

        // GET: Child Youth Addictions Worker
        public ActionResult ChildYouthAddictionsWorker()
        {
            return View();
        }

        // GET: Community Service Worker
        public ActionResult CommunityServiceWorker()
        {
            return View();
        }

        // GET: Dental Assistant II
        public ActionResult DentalAssistantII()
        {
            return View();
        }

        // GET: Developmental Service Worker
        public ActionResult DevelopmentalServiceWorker()
        {
            return View();
        }

        // GET: Early Child Care Assistant
        public ActionResult EarlyChildCareAssistant()
        {
            return View();
        }

        // GET: Fitness Health Promotion
        public ActionResult FitnessHealthPromotion()
        {
            return View();
        }

        // GET: Intra Oral Dental Assistant
        public ActionResult IntraOralDentalAssistant()
        {
            return View();
        }

        // GET: Massage Therapy
        public ActionResult MassageTherapy()
        {
            return View();
        }

        // GET: Massage Therapy Advanced Standing
        public ActionResult MassageTherapyAdvancedStanding()
        {
            return View();
        }

        // GET: Medical Lab Assistant Technician
        public ActionResult MedicalLabAssistantTechnician()
        {
            return View();
        }

        // GET: Medical Lab Assistant Technician
        public ActionResult MedicalLabTechnicianAssistant()
        {
            return View();
        }

        // GET: Medical Office Administrator
        public ActionResult MedicalOfficeAdministrator()
        {
            return View();
        }

        // GET: Medical Office Administrator
        public ActionResult DentalAdministrator()
        {
            return View();
        }

        // GET: Personal Support Worker
        public ActionResult PersonalSupportWorker()
        {
            return View();
        }

        // GET: Pharmacy Assistant
        public ActionResult PharmacyAssistant()
        {
            return View();
        }

        // GET: RehabilitationPhysiotherapy
        public ActionResult RehabilitationPhysiotherapy()
        {
            return View();
        }

        // GET: All Programs
        public ActionResult AllPrograms()
        {
            ViewBag.SideHeader = "Test";
            ViewBag.SideSubHeader1 = "Test1";
            ViewBag.SideSubText1 = "Test2";
            ViewBag.SideSubHeader2 = "Test3";
            ViewBag.SideSubText2 = "Test4";
            ViewBag.SideSubHeader3 = "Test5";
            ViewBag.SideSubText3 = "Test6";

            return View();
        }

        // GET: Medix Online
        public ActionResult MedixOnline()
        {
            return View();
        }
    }
}