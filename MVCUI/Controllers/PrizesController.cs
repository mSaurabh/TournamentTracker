using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace MVCUI.Controllers
{
    public class PrizesController : Controller
    {
        // GET: Prizes
        public ActionResult Index()
        {
            List<PrizeModel> availablePrizes = GlobalConfig.Connection.GetPrizes_All();
            return View(availablePrizes);
        }

        // GET: Prizes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prizes/Create
        // The ValidateAntiForgeryToken() method makes sure the post came from 
        // our page and not a fake simulated page.

        [ValidateAntiForgeryToken()]
        [HttpPost]
        public ActionResult Create(PrizeModel p)
        {
            try
            {
                // Very important code, since anyone can bypass the form validation by manipulating the form model.
                // Hence we wrap the code around this validation.
                if (ModelState.IsValid)
                {
                    GlobalConfig.Connection.CreatePrize(p);

                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}