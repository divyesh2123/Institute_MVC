using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Institute_MVC.Controllers
{
    public class MyWizardController : Controller
    {
        // GET: MyWizard
        public ActionResult  BasicInformation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BasicInformation(BasicInformation basic)
        {
            var myData = new MyInformation();
            myData.basicInformation = new BasicInformation();
            myData.basicInformation = basic;

            TempData["bi"] = myData;

            return RedirectToAction("AddressInfo");
        }

        public ActionResult AddressInfo()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult AddressInfo(AddressInfo addressInfo)
        {
            var myData = new MyInformation();

            myData = (MyInformation)TempData["bi"];

            myData.addressInfo = new AddressInfo();
            myData.addressInfo = addressInfo;
            return View();
        }

    }
}