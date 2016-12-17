using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB.Models;

namespace WEB.Controllers
{
    public class NCCController : Controller
    {
        // GET: NCC
        TSCDEntities db = new TSCDEntities();
        public ActionResult NCCview()
        {
            var y = db.NHACUNGCAPs.ToList();
            return PartialView(y);
        }
        //Nhập từ nhà cung cấp
        //public ActionResult nhapNCC(int mancc)
        //{
        //    NHACUNGCAP ncc= db.NHACUNGCAPs.SingleOrDefault(x => x.manhacungcap == mancc);

        //}
    }
}