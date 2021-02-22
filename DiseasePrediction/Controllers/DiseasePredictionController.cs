using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiseasePrediction.Models;
namespace DiseasePrediction.Controllers
{
    public class DiseasePredictionController : Controller
    {
        // GET: DiseasePrediction
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddDisease()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDisease(DiseaseModel diseaseModel)
        {
                return View();
        }


    }
}