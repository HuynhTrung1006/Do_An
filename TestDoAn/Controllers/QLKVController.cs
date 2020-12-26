using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDoAn.Models;

namespace TestDoAn.Controllers
{
    public class QLKVController : Controller
    {
       private QuanLyCuaHangEntites db = new QuanLyCuaHangEntites();
        // GET: QLKV
        public ActionResult IndexNhanVien()
        {
            return View(db.NhanViens.ToList());
        }
        public ActionResult IndexEmpty()
        {
            return View();
        }
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Creates(NhanVien nv)
        {
            if(ModelState.IsValid)
            {
                NhanVien a = db.NhanViens.Find(nv.manv);
                if(a==null)
                {
                    if(a.sdt.Length==10)
                    {
                        db.NhanViens.Add(nv);
                        db.SaveChanges();
                        return RedirectToAction("IndexNhanVien");
                    }
                    ModelState.AddModelError("sdt", "Độ dài 10 ký tự");
                    return View("Create");
                }
                ModelState.AddModelError("manv", "Nhân Viên Tồn Tại");
                return View("Create");
            }
            ModelState.AddModelError("macv", "Điền Thiếu Thông Tin");
            return View("Create");
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            NhanVien nv = db.NhanViens.Find(id);
            foreach(var a in db.HoaDons)
            {
                if(a.manv==nv.manv)
                {
                    return View("Error");
                }
            }
            if(nv!=null)
            {
                if (nv.tennv.Equals(Session["User"].ToString()))
                {
                    return HttpNotFound();
                }
                db.NhanViens.Remove(nv);
                //db.SaveChanges();
                
            }
            return RedirectToAction("IndexNhanVien");
        }

        [HttpGet]
        public ActionResult Detail(string id)
        {
            NhanVien nv = db.NhanViens.Find(id);
            return View(nv);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            NhanVien nv = db.NhanViens.Find(id);
            if (nv != null)
            {
                ViewBag.dscv = db.chucvus.ToList();
            }
            return View(nv);
        }

        [HttpPost]
        public ActionResult Edits(NhanVien nv)
        {
            if(ModelState.IsValid)
            {
                NhanVien a = db.NhanViens.Find(nv.manv);
                db.NhanViens.AddOrUpdate(nv);
                db.SaveChanges();
                return RedirectToAction("IndexNhanVien");
            }
            return HttpNotFound();
        }
        
        // public ActionResult Search(string id)
        // {
        //     NhanVien nv = db.NhanViens.Find(id);
        //     if(nv!=null)
        //     return PartialView(nv);
        //     return Content("Không Tìm Thấy");
        // }
    }
    }
}