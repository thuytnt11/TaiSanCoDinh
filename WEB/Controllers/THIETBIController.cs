using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB.Models;

namespace WEB.Controllers
{
    public class THIETBIController : Controller
    {
        // GET: THIETBI
        TSCDEntities db = new TSCDEntities();
        public ActionResult THIETBIview()
        {
            var y = db.THIETBIs.ToList();
            return PartialView(y);
        }
    }
}