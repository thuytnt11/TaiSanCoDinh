﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaiSanCoDinh.Models;
using PagedList.Mvc;
using PagedList;

namespace TaiSanCoDinh.Controllers
{
    public class HomeController : Controller
    {
        TSCDEntities4 db = new TSCDEntities4();
        public ActionResult ChiTiet(int maphieugiao)
        {
           // ViewBag.ChiTiet = db.CHITIETPHIEUGIAO.Select(i => i.maphieugiao.Equals(maphieugiao));

            var model = (from n in db.CHITIETPHIEUGIAOs
                         where n.maphieugiao==maphieugiao
                         select n).ToList();
            return View(model);

        }

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
            if (Convert.ToInt16(form["soluong"]) < 0)
            {
                ModelState.AddModelError("", "Số lượng thiết bị nhập vào phải là một số nguyên dương");
            }
            else
            {
                try
                {
                    DateTime ngay = Convert.ToDateTime(form["ngaynhap"]);
                    int soluong = Convert.ToInt16(form["soluong"]);
                    phieunhap.ngaynhap = ngay;
                    phieunhap.soluong = soluong;
                    string luachon = form["luachon"];
                    if (luachon == "trongtruong")
                    {
                        phieunhap.manhacungcap = null;
                    }
                    else
                    {
                        phieunhap.madonvi = null;
                    }
                    db.PHIEUNHAPs.Add(phieunhap);

                    var model1 = db.THIETBIs.Find(phieunhap.mathietbi);
                    int soluongx = 0;
                    try
                    {
                        soluongx = (int)db.CHITIETPHIEUGIAOs.Where(x => x.mathietbi == phieunhap.mathietbi).Sum(x => x.soluong);
                    }
                    catch { }
                    if (soluong > soluongx && phieunhap.manhacungcap == null)
                    {
                        if (soluongx == 0)
                        {
                                ModelState.AddModelError("", "Hiện vẫn chưa có thiết bị tại đơn vị");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Số lượng thiết bị nhập phải lớn hơn số lượng thiết bị tại đơn vị");
                        }                                                                                                                                            
                    }
                    else
                    {
                        model1.soluong += soluong;
                        db.SaveChanges();
                        ModelState.AddModelError("", "Thêm Thành Công");
                    }
                    try
                    {
                        var model33 = db.CHITIETPHIEUGIAOs.Find(phieunhap.mathietbi);
                        model33.soluong -= soluong;
                        db.SaveChanges();
                    }
                    catch { }
                    
                }
                catch
                {
                    ModelState.AddModelError("", "Thêm Thất Bại");
                }
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
        public ActionResult phieugiao(List<PHIEUGIAO> phieugiao, FormCollection form)
        {
            
            if (Convert.ToInt16(form["soluong"]) < 0)
            {
                ModelState.AddModelError("", "Số lượng thiết bị giao phải là một số nguyên dương");
            }
            else
            {
                try
                {
                    DateTime ngay = Convert.ToDateTime(form["ngaygiao"]);
                    int soluong = Convert.ToInt16(form["soluong"]);
                    string mathietbi = form["mathietbi"];
                    string tenthietbi = form["tenthietbi"];

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
                    CHITIETPHIEUGIAO ct = new CHITIETPHIEUGIAO();
                    for (int i = 0; i < key.Length; i++)
                    {
                        ct.mathietbi = Convert.ToInt16(key[i]);
                        ct.soluong = Convert.ToInt32(soluong);
                        ct.maphieugiao = pg.maphieugiao;
                        db.CHITIETPHIEUGIAOs.Add(ct);
                    }

                    var model11 = db.THIETBIs.Find(ct.mathietbi);
                    if (soluong > model11.soluong)
                    {
                        ModelState.AddModelError(" ", "Số lượng thiết bị giao không được lớn hơn số lượng thiết bị hiện có trong kho!!!");
                    }
                    else
                    {
                        model11.soluong -= soluong;

                        db.SaveChanges();
                        ModelState.AddModelError(" ", "Giao Thành Công!!!");
                    }
                }
                catch
                {
                    ModelState.AddModelError("", "Giao Thất Bại!!!");
                }
            }
            ViewData["maphongquantri"] = new SelectList(db.PHONGQUANTRIs, "maphongquantri", "tenphongquantri");
            ViewData["madonvi"] = new SelectList(db.DONVIs, "madonvi", "tendonvi");
            ViewData["manhacungcap"] = new SelectList(db.NHACUNGCAPs, "manhacungcap", "tennhacungcap");
            ViewBag.ThietBi = db.THIETBIs.ToList();

            var model = db.PHIEUGIAOs.ToList();
            return View("PhieuGiao", model);
        }

      

    }
}