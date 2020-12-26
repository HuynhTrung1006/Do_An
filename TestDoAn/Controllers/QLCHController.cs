using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDoAn.Models;

namespace TestDoAn.Controllers
{
    public class QLCHController : Controller
    {

			public ActionResult IndexNL()
		{

			return View(db.NguyenLieux.ToList());
		}
		public ActionResult FormThemNL()
		{
			return View();
		}
		[HttpPost]
		public ActionResult themNL(Models.NguyenLieu a)
		{
			if (ModelState.IsValid)
			{
				NguyenLieu b = db.NguyenLieux.Find(a.manl);
				if(b==null)
                {
					db.NguyenLieux.Add(a);
					db.SaveChanges();
					return RedirectToAction("IndexNL");
				}
				ModelState.AddModelError("manl", "Mã Nguyên Liệu đã được sử dụng");
			}
			return View("FormThemNL");
		}
		public ActionResult FormXoaNL(string id)
		{
			bool Xoa = true;
			Models.NguyenLieu a = db.NguyenLieux.Find(id);
			foreach (Models.ChiTietSanPham t in db.ChiTietSanPhams.Where(x => x.manl == id).ToList())
			{					
				Xoa = false;
				break;
			}
			ViewBag.XoaNguyenLieu = Xoa;
			
			if (a != null)
			{
				return View(a);
			}
			return RedirectToAction("IndexNL");
		}

		public ActionResult xoaNL(string id)
		{
			Models.NguyenLieu a = db.NguyenLieux.Find(id);
			if (a != null)
			{
					db.NguyenLieux.Remove(a);
					db.SaveChanges();
			}
			return RedirectToAction("IndexNL");

		}
		public ActionResult FormSuaNL(string id)
		{
			Models.NguyenLieu a = db.NguyenLieux.Find(id);
			if (a != null)
				return View(a);
			return RedirectToAction("IndexNL");
		}
		[HttpPost]
		public ActionResult suaNL(Models.NguyenLieu b)
		{

			Models.NguyenLieu a = db.NguyenLieux.Find(b.manl);
			if (a != null)
			{
				a.tenhh = b.tenhh;
				a.soluong = b.soluong;
				a.maloai = b.maloai;
				a.hsd = b.hsd;
				a.nhacungcap = b.nhacungcap;
				a.dvt = b.dvt;
				a.dongia = b.dongia;
				db.SaveChanges();
				return RedirectToAction("IndexNL");
			}
			return View("FormSuaNL");
		}


			//	QUAN LI HOA DON 
	private Models.QuanLyCuaHangEntites db = new Models.QuanLyCuaHangEntites();
        // GET: Qlch
        public ActionResult Index()
        {
            return View();
        }
		
        public ActionResult IndexHD()
        {
			ViewBag.dscthd = db.ChiTietHoaDons.ToList();
            return View(db.HoaDons.ToList());
        }
        public ActionResult FormCTHD(int id)
        {
			double tong = 0;
				List<Models.ChiTietHoaDon> ds = new List<ChiTietHoaDon>();
				foreach (var a in db.ChiTietHoaDons.Where(x => x.mahd.Equals(id)))
				{
					tong += (double)(a.soluong * a.dongia);
					ds.Add(a);
				}
			ViewBag.thanhtien = tong;
				//return View(ds);
				return RedirectToAction("IndexHD");

        }

		public ActionResult Search(string id)
		{
			int a = int.Parse(id);
			HoaDon hd = db.HoaDons.Find(a);
			if (hd != null)
				return PartialView(hd);
			return Content("Không Tìm Thấy");
		}
		
		

		[HttpGet]
		public ActionResult xoahoadon(int id)
        {
			HoaDon a = db.HoaDons.Find(id);
			List<ChiTietHoaDon> ds = db.ChiTietHoaDons.Where(x => x.mahd == a.mahd).ToList();
			foreach(var b in ds)
            {
                if (b != null)
                {
					db.ChiTietHoaDons.Remove(b);
					db.SaveChanges();
				}
			}
			
				db.HoaDons.Remove(a);
				db.SaveChanges();
            
			return RedirectToAction("IndexHD");
        }


		public ActionResult IndexNH()
        {
			return View(db.NguyenLieux.ToList());
        }

		public ActionResult add(string id)
        {
			NguyenLieu a = db.NguyenLieux.Find(id);
			return View(a);
        }

		[HttpGet]
		public ActionResult addNL(string id)
        {
			NguyenLieu nl = db.NguyenLieux.Find(id);
			if(nl!=null)
            {
				int a = int.Parse(Request["slnhap"].ToString());
				if (a > 0)
				{
					nl.soluong = nl.soluong + a;
					db.NguyenLieux.AddOrUpdate(nl);
					db.SaveChanges();
					return RedirectToAction("IndexNH");
				}
				ModelState.AddModelError("slnhap", "Số lượng lớn hơn 0!!!");
			}
			return View("add");
        }
	

	
    }
}

       }
}

