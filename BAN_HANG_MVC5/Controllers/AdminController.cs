using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAN_HANG_MVC5.Models;

namespace BAN_HANG_MVC5.Controllers
{
    public class AdminController : Controller
    {
        BanQuanAoEntities2 db = new BanQuanAoEntities2(); 
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult XemChiTiet()
        {
            return View(db.KhachHangs.OrderBy(n => n.IdKH));
        }

        [HttpPost]
        public ActionResult LoginAdmin(FormCollection collection)
        {
            string Taikhoan = collection["txtUser"].ToString();
            string Matkhau = collection["txtPass"].ToString();
            ThanhVien thanhvien = db.ThanhViens.SingleOrDefault(n => n.TaiKhoan == Taikhoan && n.MatKhau == Matkhau);
             if (thanhvien !=null)
            {
                Session["user"] = thanhvien;
                return RedirectToAction("XemChiTiet");
            }
            return Content("Tài khoản hoặc mật khẩu không đúng");

        }
    }
}