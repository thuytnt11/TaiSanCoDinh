using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB.Models;

namespace WEB.Controllers
{
    public class DONVIController : Controller
    {
        // GET: DONVI
        TSCDEntities db = new TSCDEntities();
        public ActionResult DONVIview()
        {
            var y = db.DONVIs.ToList();
            return PartialView(y);
        }
    }
}