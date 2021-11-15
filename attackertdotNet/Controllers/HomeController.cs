using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using attackertdotNet.Models;
using DatalibraryMonster.Logic;
using DatalibraryMonster.Models;

namespace attackertdotNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Your signup page.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(MadScientistUIModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = ScientistProcess.CreateScientist(model.ScientistID,
                    model.Name,
                    model.Email);
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]
        public ActionResult ViewScientists()
        {
            ViewBag.Message = "List of Our Scientists";
            var data = ScientistProcess.LoadScientists();
          
            return View(data);

        }
        
    }
}