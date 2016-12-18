using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB.Models;

namespace WEB.Controllers
{
    public class NHAPTHEMController : Controller
    {
        // GET: THIETBI
        TSCDEntities db = new TSCDEntities();
        public ActionResult NHAPTHEMview()
        {
            var y = db.THIETBIs.ToList();
            return PartialView(y);
        }
    }
}