using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using PUB;

namespace BUS
{
    public class thietbiBUS
    {
        public static List<thietbiPUB> dsthietbi()
        {
            return DAL.thietbiDAL.dsthietbi();
        }
        public static List<dskho> dsthietbikho(DateTime thoidiem)
        {
            return DAL.thietbiDAL.dsthietbikho(thoidiem);
        }
        public static List<thietbiPUB> dsthietbitt(int Matinhtrang, DateTime Thoidiem)
        {
            return DAL.thietbiDAL.dsthietbitt(Matinhtrang, Thoidiem);
        }
        public static void themthietbi(string Tenthietbi,int Dongia, string Thongsokythuat,DateTime Ngaysanxuat,DateTime Ngayduavaosudung, DateTime Ngaycapnhat, int  Soluong,int Madonvitinh, int Maloai, int Maphongquantri, int Matinhtrang)
        {
            THIETBI tb = new THIETBI();
            tb.tenthietbi = Tenthietbi;
            tb.dongia = Dongia;
            tb.thongsokythuat = Thongsokythuat;
            tb.ngaysanxuat = Ngaysanxuat;
            tb.ngayduavaosudung = Ngayduavaosudung;
            tb.ngaycapnhat = Ngaycapnhat;
            tb.soluong = Soluong;
            tb.madonvitinh = Madonvitinh;
            tb.maloai = Maloai;
            tb.maphongquantri = Maphongquantri;
            tb.matinhtrang = Matinhtrang;
            thietbiDAL.themthietbi(tb);
        }
        public static void xoathietbi(int mathietbi)
        {
            THIETBI tb = new THIETBI();
            tb.mathietbi = mathietbi;
            thietbiDAL.xoathietbi(tb);
        }
        public static void suathietbi(int Mathietbi , string Tenthietbi, int Dongia, string Thongsokythuat, DateTime Ngaysanxuat, DateTime Ngayduavaosudung,DateTime Ngaycapnhat, int Soluong, int Madonvitinh, int Maloai, int Maphongquantri, int Matinhtrang)
        {
            THIETBI tb = new THIETBI();
            tb.mathietbi = Mathietbi;
            tb.tenthietbi = Tenthietbi;
            tb.dongia = Dongia;
            tb.thongsokythuat = Thongsokythuat;
            tb.ngaysanxuat = Ngaysanxuat;
            tb.ngayduavaosudung = Ngayduavaosudung;
            tb.ngaycapnhat = Ngaycapnhat;
            tb.soluong = Soluong;
            tb.madonvitinh = Madonvitinh;
            tb.maloai = Maloai;
            tb.maphongquantri = Maphongquantri;
            tb.matinhtrang = Matinhtrang;
            thietbiDAL.suathietbi(tb);
        }
        public static List<thietbiPUB> dsthietbiloctt(int Matinhtrang)
        {
            return DAL.thietbiDAL.dsthietbiloctt(Matinhtrang);
        }
        public static List<thietbiPUB> dsthietbilocl(int Maloai)
        {
            return DAL.thietbiDAL.dsthietbilocl(Maloai);
        }
        public static List<thietbiPUB> dsthietbitim(string Ten)
        {
            return DAL.thietbiDAL.dsthietbitim(Ten);
        }
    }
}
