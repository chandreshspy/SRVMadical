using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRV.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sale()
        {
            return View();
        }
        public ActionResult Modification()
        {
            return View();
        }
        public ActionResult Purches()
        {
            return View();
        }
    }
}