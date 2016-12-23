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
        TSCDEntities4 db = new TSCDEntities4();

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
            ViewData["mathietbi"] = new SelectList(db.THIETBIs, "mathietbi", "tenthietbi");
            ViewData["manhacungcap"] = new SelectList(db.NHACUNGCAPs, "manhacungcap", "tennhacungcap");
            ViewData["madonvi"] = new SelectList(db.DONVIs, "madonvi", "tendonvi");
            ViewBag.ThietBi = db.THIETBIs.ToList();

            var model = db.PHIEUNHAPs.ToList();
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
                db.PHIEUNHAPs.Add(phieunhap);
                
                
                var model1 = db.THIETBIs.Find(phieunhap.mathietbi);
                model1.soluong += soluong;


                db.SaveChanges();
                ModelState.AddModelError("", "Thêm Thành Công");
            }
            catch 
            {
                ModelState.AddModelError("", "Thêm Thất Bại");
            }


            ViewBag.ThietBi = db.THIETBIs.ToList();
            ViewData["mathietbi"] = new SelectList(db.THIETBIs, "mathietbi", "tenthietbi");
            ViewData["manhacungcap"] = new SelectList(db.NHACUNGCAPs, "manhacungcap", "tennhacungcap");
            ViewData["madonvi"] = new SelectList(db.DONVIs, "madonvi", "tendonvi");

            var model = db.PHIEUNHAPs.ToList();
            return View("PhieuNhap", model);

        }
        public ActionResult PhieuGiao()
        {

            
            ViewData["maphongquantri"] = new SelectList(db.PHONGQUANTRIs, "maphongquantri", "tenphongquantri");
            ViewData["madonvi"] = new SelectList(db.DONVIs, "madonvi", "tendonvi");
            ViewData["manhacungcap"] = new SelectList(db.NHACUNGCAPs, "manhacungcap", "tennhacungcap");
            ViewBag.ThietBi = db.THIETBIs.ToList();

            var model = db.PHIEUGIAOs.ToList();
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
                
                db.PHIEUGIAOs.Add(pg);
                db.SaveChanges();

                for (int i = 0; i < key.Length; i++)
                {
                    CHITIETPHIEUGIAO ct = new CHITIETPHIEUGIAO();
                    ct.mathietbi = Convert.ToInt16(key[i]);
                    ct.soluong = Convert.ToInt32(quantity[i]);
                    ct.maphieugiao = pg.maphieugiao;
                    db.CHITIETPHIEUGIAOs.Add(ct);
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


            ViewData["maphongquantri"] = new SelectList(db.PHONGQUANTRIs, "maphongquantri", "tenphongquantri");
            ViewData["madonvi"] = new SelectList(db.DONVIs, "madonvi", "tendonvi");
            ViewData["manhacungcap"] = new SelectList(db.NHACUNGCAPs, "manhacungcap", "tennhacungcap");
            ViewBag.ThietBi = db.THIETBIs.ToList();

            var model = db.PHIEUGIAOs.ToList();
            return View("PhieuGiao", model);
        }

        public ActionResult ChiTiet(CHITIETPHIEUGIAO maphieugiao )
        {
            ViewBag.ChiTiet = db.CHITIETPHIEUGIAOs.Select(i => i.maphieugiao.Equals(maphieugiao));
            //ViewBag.ChiTiet = db.CHITIETPHIEUGIAO.ToList();

            return View();

        }

    }
}