using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class DiscoverMedixController : Controller
    {
        // GET: DiscoverMedix
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

        // GET: History
        public ActionResult History()
        {
            return View();
        }

        // GET: Laptop Initiative
        public ActionResult LaptopInitiative()
        {
            return View();
        }

        // GET: Transcript Request
        public ActionResult TranscriptRequest()
        {
            return View();
        }

        // GET: Partnerships
        public ActionResult PartnerSchools()
        {
            return View();
        }

        public ActionResult VirtualTour()
        {
            return View();
        }

        public ActionResult Testimonials()
        {
            return View();
        }

        public ActionResult CareersAtMedix()
        {
            return View();
        }
    }
}