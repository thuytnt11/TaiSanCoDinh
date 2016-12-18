using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB.Models;

namespace WEB.Controllers
{
    public class NHAPMOIController : Controller
    {
        // GET: NHAPMOI
        TSCDEntities db = new TSCDEntities();
        public ActionResult NHAPMOIview()
        {
            return View();
        }
    }
}