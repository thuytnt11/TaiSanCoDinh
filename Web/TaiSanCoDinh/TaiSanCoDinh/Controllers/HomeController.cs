using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaiSanCoDinh.Models;

namespace TaiSanCoDinh.Controllers
{
    public class HomeController : Controller
    {
        TSCDEntities2 db = new TSCDEntities2();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult PhieuNhap()
        {
            ViewData["mathietbi"] = new SelectList(db.THIETBI, "mathietbi", "tenthietbi");
            ViewData["manhacungcap"] = new SelectList(db.NHACUNGCAP, "manhacungcap", "tennhacungcap");
            ViewData["madonvi"] = new SelectList(db.DONVI, "madonvi", "tendonvi");
            ViewBag.ThietBi = db.THIETBI.ToList();

            var model = db.PHIEUNHAP.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult phieunhap(PHIEUNHAP phieunhap, FormCollection form)
        {
            //Nhận dữ liệu từ PhieuNhap
            try
            {
                DateTime ngay = Convert.ToDateTime(form["ngaynhap"]);
                int soluong = Convert.ToInt16(form["soluong"]);
                phieunhap.ngaynhap = ngay;
                phieunhap.soluong = soluong;
                string luachon = form["luachon"];
                if(luachon == "trongtruong")
                {
                    phieunhap.manhacungcap = null;
                }
                else
                {
                    phieunhap.madonvi = null;
                }
                db.PHIEUNHAP.Add(phieunhap);
                
                
                var model1 = db.THIETBI.Find(phieunhap.mathietbi);
                model1.soluong += soluong;


                db.SaveChanges();
                ModelState.AddModelError("", "Thêm Thành Công");
            }
            catch 
            {
                ModelState.AddModelError("", "Thêm Thất Bại");
            }


            ViewBag.ThietBi = db.THIETBI.ToList();
            ViewData["mathietbi"] = new SelectList(db.THIETBI, "mathietbi", "tenthietbi");
            ViewData["manhacungcap"] = new SelectList(db.NHACUNGCAP, "manhacungcap", "tennhacungcap");
            ViewData["madonvi"] = new SelectList(db.DONVI, "madonvi", "tendonvi");

            var model = db.PHIEUNHAP.ToList();
            return View("PhieuNhap", model);

        }
        public ActionResult PhieuGiao()
        {

            
            ViewData["maphongquantri"] = new SelectList(db.PHONGQUANTRI, "maphongquantri", "tenphongquantri");
            ViewData["madonvi"] = new SelectList(db.DONVI, "madonvi", "tendonvi");
            ViewData["manhacungcap"] = new SelectList(db.NHACUNGCAP, "manhacungcap", "tennhacungcap");
            ViewBag.ThietBi = db.THIETBI.ToList();

            var model = db.PHIEUGIAO.ToList();
            return View(model);
        }
        //public ActionResult phieugiao(PHIEUGIAO phieugiao, FormCollection form)
        //{
        //    try
        //    {
        //        DateTime ngay = Convert.ToDateTime(form["ngaygiao"]);
        //        int soluong = Convert.ToInt16(form["soluong"]);
        //        phieugiao.ngaygiao = ngay;
        //        db.PHIEUGIAO.Add(phieugiao);

        //        int mathietbi = Convert.ToInt16(form[""]);

        //        db.SaveChanges();
        //        ModelState.AddModelError(" ", "Giao Thành Công!!!");
        //    }
        //    catch
        //    {
        //        ModelState.AddModelError("", "Giao Thất Bại!!!");
        //    }


        //    ViewData["maphongquantri"] = new SelectList(db.PHONGQUANTRI, "maphongquantri", "tenphongquantri");
        //    ViewData["madonvi"] = new SelectList(db.DONVI, "madonvi", "tendonvi");
        //    ViewData["manhacungcap"] = new SelectList(db.NHACUNGCAP, "manhacungcap", "tennhacungcap");
        //    ViewBag.ThietBi = db.THIETBI.ToList();

        //    var model = db.PHIEUGIAO.ToList();
        //    return View("PhieuGiao", model);
        //}
    }
}