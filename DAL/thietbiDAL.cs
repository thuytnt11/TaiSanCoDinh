using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using PUB;

namespace DAL
{
    public class thietbiDAL
    {
        public static List<thietbiPUB> dsthietbi()
        {
            List<thietbiPUB> dstb = new List<thietbiPUB>();
            using (TSCDEntities t = new TSCDEntities())
            {
                var query = from s in t.THIETBIs
                            select s;
                foreach (var row in query)
                {
                    thietbiPUB tb = new thietbiPUB();
                    tb.Mathietbi = row.mathietbi;
                    tb.Tenthietbi = row.tenthietbi;
                    tb.Dongia = row.dongia;
                    tb.Thongsokythuat = row.thongsokythuat;
                    tb.Ngaysanxuat = row.ngaysanxuat;
                    tb.Ngayduavaosudung = row.ngayduavaosudung;
                    tb.Ngaycapnhat = row.ngaycapnhat;
                    tb.Soluong = row.soluong;
                    tb.Madonvitinh = row.madonvitinh;
                    tb.Maloai = row.maloai;
                    tb.Maphongquantri = row.maphongquantri;
                    tb.Matinhtrang = row.matinhtrang;
                    dstb.Add(tb);
                }
                return dstb;
            }
        }
        public static List<thietbiPUB> dsthietbikho(DateTime thoidiem)
        {
            List<thietbiPUB> dstb = new List<thietbiPUB>();
            using (TSCDEntities t = new TSCDEntities())
            {
                var query = from s in t.THIETBIs
                            select s;
                foreach (var row in query)
                {
                    thietbiPUB tb = new thietbiPUB();
                    tb.Mathietbi = row.mathietbi;
                    tb.Tenthietbi = row.tenthietbi;
                    tb.Dongia = row.dongia;
                    tb.Thongsokythuat = row.thongsokythuat;
                    tb.Ngaysanxuat = row.ngaysanxuat;
                    tb.Ngayduavaosudung = row.ngayduavaosudung;
                    tb.Ngaycapnhat = row.ngaycapnhat;
                    //tính số lượng tồn
                    int soluongnhap = 0;
                    try
                    {
                        soluongnhap = (int)t.PHIEUNHAPs.Where(x => x.mathietbi == tb.Mathietbi && x.ngaynhap <= thoidiem).Sum(x => x.soluong);
                    }
                    catch { }
                    int soluongxuat = 0;
                    try
                    {
                        soluongxuat = (int)t.CHITIETPHIEUGIAOs.Where(x => x.mathietbi == tb.Mathietbi && x.PHIEUGIAO.ngaygiao <= thoidiem).Sum(x => x.soluong);
                    }
                    catch { }
                    //tính số lượng xong
                    if (soluongnhap == 0)
                    {
                        tb.Soluong = 0;
                    }
                    if(soluongnhap != 0 && soluongxuat ==0)
                    {
                        tb.Soluong = soluongnhap;
                    }
                    else
                    {
                        tb.Soluong = soluongnhap - soluongxuat;
                    }
                    tb.Madonvitinh = row.madonvitinh;
                    tb.Maloai = row.maloai;
                    tb.Maphongquantri = row.maphongquantri;
                    tb.Matinhtrang = row.matinhtrang;
                    dstb.Add(tb);
                }
                return dstb;
            }
        }
        public static List<thietbiPUB> dsthietbitt(int Matinhtrang, DateTime thoidiem)
        {
            List<thietbiPUB> dstb = new List<thietbiPUB>();
            using (TSCDEntities t = new TSCDEntities())
            {
                    var query = from s in t.THIETBIs
                                where s.matinhtrang == Matinhtrang && s.ngaycapnhat <= thoidiem
                                select s;
                    foreach (var row in query)
                    {
                        thietbiPUB tb = new thietbiPUB();
                        tb.Mathietbi = row.mathietbi;
                        tb.Tenthietbi = row.tenthietbi;
                        tb.Dongia = row.dongia;
                        tb.Thongsokythuat = row.thongsokythuat;
                        tb.Ngaysanxuat = row.ngaysanxuat;
                        tb.Ngayduavaosudung = row.ngayduavaosudung;
                        tb.Ngaycapnhat = row.ngaycapnhat;
                        tb.Soluong = row.soluong;
                        tb.Madonvitinh = row.madonvitinh;
                        tb.Maloai = row.maloai;
                        tb.Maphongquantri = row.maphongquantri;
                        tb.Matinhtrang = row.matinhtrang;
                        dstb.Add(tb);
                    }
                }
                return dstb;
            
        }
        public static void themthietbi(THIETBI tb)
        {
            using (TSCDEntities ts = new TSCDEntities())
            {
                ts.THIETBIs.Add(tb);
                ts.SaveChanges();

            }
        }
        public static void xoathietbi(THIETBI tb)
        {
            using (TSCDEntities ts = new TSCDEntities())
            {
                THIETBI tbb = ts.THIETBIs.Find(tb.mathietbi);
                ts.THIETBIs.Remove(tbb);
                ts.SaveChanges();

            }
        }
        public static void suathietbi(THIETBI tb)
        {
            using (TSCDEntities ts = new TSCDEntities())
            {
                THIETBI tbb = ts.THIETBIs.Find(tb.mathietbi);
                tbb.tenthietbi = tb.tenthietbi;
                tbb.dongia = tb.dongia;
                tbb.ngaysanxuat = tb.ngaysanxuat;
                tbb.ngayduavaosudung = tb.ngayduavaosudung;
                tbb.ngaycapnhat = tb.ngaycapnhat;
                tbb.soluong = tb.soluong;
                tbb.madonvitinh = tb.madonvitinh;
                tbb.maloai = tb.maloai;
                tbb.maphongquantri = tb.maphongquantri;
                tbb.matinhtrang = tb.matinhtrang;
                ts.SaveChanges();

            }
        }
        public static List<thietbiPUB> dsthietbiloctt(int Matinhtrang)
        {
            List<thietbiPUB> dstbltt = new List<thietbiPUB>();
            using (TSCDEntities t = new TSCDEntities())
            {
                var query = from s in t.THIETBIs where s.matinhtrang == Matinhtrang
                            select s;
                foreach (var row in query)
                {
                    thietbiPUB tb = new thietbiPUB();
                    tb.Mathietbi = row.mathietbi;
                    tb.Tenthietbi = row.tenthietbi;
                    tb.Dongia = row.dongia;
                    tb.Thongsokythuat = row.thongsokythuat;
                    tb.Ngaysanxuat = row.ngaysanxuat;
                    tb.Ngayduavaosudung = row.ngayduavaosudung;
                    tb.Ngaycapnhat = row.ngaycapnhat;
                    tb.Soluong = row.soluong;
                    tb.Madonvitinh = row.madonvitinh;
                    tb.Maloai = row.maloai;
                    tb.Maphongquantri = row.maphongquantri;
                    tb.Matinhtrang = row.matinhtrang;
                    dstbltt.Add(tb);
                }
                return dstbltt;
            }
        }
        public static List<thietbiPUB> dsthietbilocl(int Maloai)
        {
            List<thietbiPUB> dstbll = new List<thietbiPUB>();
            using (TSCDEntities t = new TSCDEntities())
            {
                var query = from s in t.THIETBIs
                            where s.maloai == Maloai
                            select s;
                foreach (var row in query)
                {
                    thietbiPUB tb = new thietbiPUB();
                    tb.Mathietbi = row.mathietbi;
                    tb.Tenthietbi = row.tenthietbi;
                    tb.Dongia = row.dongia;
                    tb.Thongsokythuat = row.thongsokythuat;
                    tb.Ngaysanxuat = row.ngaysanxuat;
                    tb.Ngayduavaosudung = row.ngayduavaosudung;
                    tb.Ngaycapnhat = row.ngaycapnhat;
                    tb.Soluong = row.soluong;
                    tb.Madonvitinh = row.madonvitinh;
                    tb.Maloai = row.maloai;
                    tb.Maphongquantri = row.maphongquantri;
                    tb.Matinhtrang = row.matinhtrang;
                    dstbll.Add(tb);
                }
                return dstbll;
            }
        }
        public static List<thietbiPUB> dsthietbitim(string Ten)
        {
            List<thietbiPUB> dstbtim = new List<thietbiPUB>();
            using (TSCDEntities t = new TSCDEntities())
            {
                var query = from s in t.THIETBIs
                            where s.tenthietbi.Contains(@Ten)
                            select s;
                foreach (var row in query)
                {
                    thietbiPUB tb = new thietbiPUB();
                    tb.Mathietbi = row.mathietbi;
                    tb.Tenthietbi = row.tenthietbi;
                    tb.Dongia = row.dongia;
                    tb.Thongsokythuat = row.thongsokythuat;
                    tb.Ngaysanxuat = row.ngaysanxuat;
                    tb.Ngayduavaosudung = row.ngayduavaosudung;
                    tb.Ngaycapnhat = row.ngaycapnhat;
                    tb.Soluong = row.soluong;
                    tb.Madonvitinh = row.madonvitinh;
                    tb.Maloai = row.maloai;
                    tb.Maphongquantri = row.maphongquantri;
                    tb.Matinhtrang = row.matinhtrang;
                    dstbtim.Add(tb);
                }
                return dstbtim;
            }
        }
    }
}

