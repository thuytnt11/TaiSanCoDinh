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
        TSCDEntities3 db = new TSCDEntities3();

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
        [HttpPost]
        public ActionResult phieugiao( List<PHIEUGIAO>  phieugiao, FormCollection form)
        {
            try
            {
                DateTime ngay = Convert.ToDateTime(form["ngaygiao"]);
                string soluong = form["soluong"];
                string mathietbi = form["mathietbi"];
                string tenthietbi = form["tenthietbi"];

                string[] quantity = soluong.Split(',');
                string[] key = mathietbi.Split(',');
                string[] name = tenthietbi.Split(',');

                PHIEUGIAO pg = new PHIEUGIAO();
                pg.ngaygiao = ngay;
                pg.daky = 1;
                pg.tinhtrang = "1";
                pg.maphongquantri = Convert.ToInt16(form["maphongquantri"]);
                pg.madonvi = Convert.ToInt16(form["madonvi"]);
                
                db.PHIEUGIAO.Add(pg);
                db.SaveChanges();

                for (int i = 0; i < key.Length; i++)
                {
                    CHITIETPHIEUGIAO ct = new CHITIETPHIEUGIAO();
                    ct.mathietbi = Convert.ToInt16(key[i]);
                    ct.soluong = Convert.ToInt32(quantity[i]);
                    ct.maphieugiao = pg.maphieugiao;
                    db.CHITIETPHIEUGIAO.Add(ct);
                }

                    //phieugiao.ngaygiao = ngay;
                    //db.PHIEUGIAO.Add(phieugiao);

                    db.SaveChanges();
                ModelState.AddModelError(" ", "Giao Thành Công!!!");
            }
            catch
            {
                ModelState.AddModelError("", "Giao Thất Bại!!!");
            }


            ViewData["maphongquantri"] = new SelectList(db.PHONGQUANTRI, "maphongquantri", "tenphongquantri");
            ViewData["madonvi"] = new SelectList(db.DONVI, "madonvi", "tendonvi");
            ViewData["manhacungcap"] = new SelectList(db.NHACUNGCAP, "manhacungcap", "tennhacungcap");
            ViewBag.ThietBi = db.THIETBI.ToList();

            var model = db.PHIEUGIAO.ToList();
            return View("PhieuGiao", model);
        }

        public ActionResult ChiTiet(CHITIETPHIEUGIAO maphieugiao )
        {
            ViewBag.ChiTiet = db.CHITIETPHIEUGIAO.Select(i => i.maphieugiao.Equals(maphieugiao));
            //ViewBag.ChiTiet = db.CHITIETPHIEUGIAO.ToList();

            return View();

        }

    }
}