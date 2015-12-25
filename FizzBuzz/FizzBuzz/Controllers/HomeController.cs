using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzz.Models;


namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private FizzBuzzRules.FizzBuzzRules _rules = new FizzBuzzRules.FizzBuzzRules();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FizzBuzzModel model)
        {
            if (model.Max < model.Min)
            {
                ModelState.AddModelError("Error","The max number must be greater than the min number");
                return View("Index", model);
            }

            model.Results = _rules.FindFizzBuzzList(model.Min, model.Max);
            return View("Index",model);
        }
    }
}
