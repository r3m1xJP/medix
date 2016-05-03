using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class CareerServicesController : Controller
    {
        // GET: CareerServices
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

        // GET: MedixAdvantage
        public ActionResult MedixAdvantage()
        {
            return View();
        }

        public ActionResult JobSearchTips()
        {
            return View();
        }

        public ActionResult ResumeTips()
        {
            return View();
        }

        public ActionResult InterviewTips()
        {
            return View();
        }

        public ActionResult ProfessionalTips()
        {
            return View();
        }

        public ActionResult KPIandDefault()
        {
            return View();
        }

    

        public ActionResult HireAGrad()
        {
            return View();
        } 
    }
}