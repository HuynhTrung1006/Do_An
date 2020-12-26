using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDoAn.Models;

namespace TestDoAn.Controllers
{
    public class HomeController : Controller
    {
        
	 private QuanLyCuaHangEntites db = new QuanLyCuaHangEntites();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(string txtUser, string txtPassword)
        {
            if(ModelState.IsValid)
            {
                if (txtUser == "" && txtPassword == "")
                {
                    ViewBag.flag = 1;
                }
                else
                {
                    NhanVien a = db.NhanViens.Find(txtUser);
                    if (a != null)
                    {
                        if (a.matkhau.Trim().Equals(txtPassword))
                        {
                            Session["User"] = a.tennv;
                            Session["NhanVien"] = a.manv;
                            Session["ChucVu"] = a.macv.Trim();
                            if (a.macv.Trim().Equals("quanly"))
                            {
                                return RedirectToAction("Index", "QLCH");
                            }
                            else if (a.macv.Trim().Equals("quanlykv"))
                            {
                                return RedirectToAction("IndexEmpty", "QLKV");
                            }
                            else
                                return RedirectToAction("Index", "NhanVien");
                        }
                        else
                        {
                            ViewBag.flag = 2;
                        }
                    }
                    else if (a == null)
                    {
                        ViewBag.flag = 3;
                    }
                }
            }
            return View("Index");
        }

        public ActionResult logout()
        {
            Session["User"] = null;
            Session["ChucVu"] = null;
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return RedirectToAction("Create", "QLKV");
        }	
    }
}