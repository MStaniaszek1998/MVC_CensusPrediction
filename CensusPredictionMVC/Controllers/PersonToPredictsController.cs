using CensusPredictionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CensusPredictionMVC.Controllers
{
    public class PersonToPredictsController : Controller
    {
        // GET: PersonToPredicts
        public ActionResult CensusPrediction()
        {
            //Creating a PersonToPredictModel for a user
            PersonToPredictModel toPredict = new PersonToPredictModel();
            
            return View(toPredict);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CensusPrediction(PersonToPredictModel predictModel)
        {
            if (ModelState.IsValid)
            {
                ConverterModels.ConverterToItemList.PredictScore(predictModel);
                predictModel.Above50kProp = ConverterModels.ConverterToItemList.above50k *100;
                predictModel.Below50kProp = ConverterModels.ConverterToItemList.below50k * 100;
                return View(predictModel);
            }
            else
            {
                return View();
            }
        }
    }
}