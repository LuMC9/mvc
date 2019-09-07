using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ItineraryController : Controller
    {
        // GET: Itinerary
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new ItinaryItem();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(ItinaryItem data)
        {
            if (ModelState.IsValid)
            {

            }
            else {
                ModelState.AddModelError("", "The data entered is invalid");
                }

            return View();

        }
    }
}