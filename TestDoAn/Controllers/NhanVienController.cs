using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDoAn.Models;

namespace TestDoAn.Controllers
{
    public class NhanVienController : Controller
    {
        // private Models.QuanLyCuaHangEntites db = new Models.QuanLyCuaHangEntites();
        // // GET: NhanVien
        // public ActionResult Index()
        // {
        //     return View();
        // }
        // public ActionResult IndexSP()
        // {
        //     return View(db.SanPhams.ToList());
        // }

        // public ActionResult chonMua(string id)
        // {
        //     Models.HoaDon pmh = Session["MuaHang"] as Models.HoaDon;

        //     Models.SanPham sp = db.SanPhams.Find(id);
        //     int soluong = int.Parse(Request[id].ToString());
        //     Models.ChiTietHoaDon c = new Models.ChiTietHoaDon();
        //     foreach(var a in pmh.ChiTietHoaDons.Where(x=>x.masp==id))
        //     {
        //             a.soluong = a.soluong + soluong;
        //         c.masp = id;
        //         c.SanPham = sp;
        //         c.soluong = a.soluong;
        //         c.dongia = sp.dongia;
        //         pmh.ChiTietHoaDons.Remove(a);
        //         pmh.ChiTietHoaDons.Add(c);
        //         return RedirectToAction("IndexSP");
        //     }

        //     c.masp = id;
        //     c.SanPham = sp;
        //     c.soluong = soluong;
        //     c.dongia = sp.dongia;

        //     pmh.ChiTietHoaDons.Add(c);

        //     return RedirectToAction("IndexSP");
        // }

        // public ActionResult giohang()
        // {
        //     Models.HoaDon pmh = Session["MuaHang"] as Models.HoaDon;
        //     return View("giohang",pmh);
        // }

        // public ActionResult xoagiohang(string masp)
        // {
        //     HoaDon pmh = Session["MuaHang"] as HoaDon;
        //     ChiTietHoaDon c = null;
        //     foreach(var a in pmh.ChiTietHoaDons.Where(x => x.masp == masp)){
        //         c = a;
        //         break;
        //     }
        //     if (c != null) pmh.ChiTietHoaDons.Remove(c);
        //     return View("giohang", pmh);
        // }

        // [HttpPost]
        // public ActionResult lapHoaDon(HoaDon hd)
        // {
        //     if(ModelState.IsValid)
        //     {
        //         hd.manv = Session["NhanVien"].ToString();
        //         HoaDon pmh = Session["MuaHang"] as HoaDon;
                

        //         db.HoaDons.Add(hd);
        //         db.SaveChanges();
        //         foreach (var a in pmh.ChiTietHoaDons.ToList())
        //         {
        //             ChiTietHoaDon b = new ChiTietHoaDon();
        //             b.mahd = hd.mahd;
        //             b.masp = a.masp;
        //             b.soluong = a.soluong;
        //             b.dongia = a.dongia;
        //             foreach(var y in db.SanPhams.Where(x=>x.masp==b.masp))
        //             {
        //                 foreach (var c in db.ChiTietSanPhams.Where(x => x.masp == y.masp))
        //                 {
        //                     foreach (var e in db.NguyenLieux.Where(x => x.manl == c.manl))
        //                     {
        //                         if(e.soluong<=0)
        //                         {
        //                             return View("errorslnl");
        //                         }
        //                         else
        //                         {
        //                             NguyenLieu n = new NguyenLieu();
        //                             n = e;
        //                             n.soluong = e.soluong - (b.soluong * c.soluong);
        //                             if(n.soluong<=0)
        //                             {
        //                                 return View("errorslnl");
        //                             }    
        //                             db.NguyenLieux.AddOrUpdate(n);
        //                         }

        //                     }
        //                 }
        //             }
                    
        //             db.ChiTietHoaDons.Add(b);
        //             db.SaveChanges();
        //         }

        //         Session["MuaHang"] = new HoaDon();

        //     }

        //     return RedirectToAction("IndexSP");
        // }
    }
}