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

        public ActionResult Index()
        {
            var model = new FizzBuzzModel();
            var rules = new FizzBuzzRules.FizzBuzzRules();
            model.Max = 100;
            model.Min = 1;
            model.Results = rules.FindFizzBuzzList(model.Min, model.Max);
            
            return View(model);
        }

    }
}
