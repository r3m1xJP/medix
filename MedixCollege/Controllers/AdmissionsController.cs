using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedixCollege.Controllers
{
    public class AdmissionsController : Controller
    {
        // GET: Admissions
        public ActionResult Index()
        {
            ViewBag.HeroText = "";
            ViewBag.BodyHeaderText = "";

            ViewBag.SideHeader = "Links";
            ViewBag.SideSubHeader1 = "Google";
            ViewBag.SideSubText1 = "<a href='http://www.google.com'>www.google.com</a>";
            ViewBag.SideSubHeader2 = "Google Canada";
            ViewBag.SideSubText2 = "<a href='http://www.google.ca'>www.google.ca</a>";
            ViewBag.SideSubHeader3 = "NBA";
            ViewBag.SideSubText3 = "<a href='http://www.nba.com'>www.nba.com</a>";
            return View();
        }

        // GET: EmploymentOntario
        public ActionResult EmploymentOntario()
        {
            return View();
        }

        // GET: LifelongLearningPlan
        public ActionResult LifelongLearningPlan()
        {
            return View();
        }

        // GET: OSAP
        public ActionResult OSAP()
        {
            return View();
        }

        // GET: OutOfProvinceStudents
        public ActionResult OutOfProvinceStudents()
        {
            return View();
        }

        // GET: RegisteredEducationSavingsPlans
        public ActionResult RegisteredEducationSavingsPlans()
        {
            return View();
        }

        // GET: SecondCareers
        public ActionResult SecondCareers()
        {
            return View();
        }

        // GET: StudentLinesOfCredit
        public ActionResult StudentLinesOfCredit()
        {
            return View();
        }

        // GET: FinancialOptions
        public ActionResult FinancialOptions()
        {
            return View();
        }

        // GET: MonthlyPaymentPlan
        public ActionResult MonthlyPaymentPlan()
        {
            return View();
        }

        public ActionResult CanadaJobGrant()
        {
            return View();
        }

    }
}