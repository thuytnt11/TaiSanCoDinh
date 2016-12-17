using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB.Models;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        TSCDEntities db = new TSCDEntities();
        public ActionResult Index()
        {
            return View();
        }
<<<<<<< HEAD
=======
        public ActionResult NCCview()
        {
            var y = db.NHACUNGCAPs.ToList();
            return PartialView(y);
        }
        public ActionResult DONVIview()
        {
            var y = db.DONVIs.ToList();
            return PartialView(y);
        }
		//ghi chú
>>>>>>> origin/master
    }
}