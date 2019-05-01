using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAN_HANG_MVC5.Models;
using System.Net.Mail;

namespace BAN_HANG_MVC5.Controllers
{
    public class HomeController : Controller
    {
        BanQuanAoEntities2 db = new BanQuanAoEntities2();
        public ActionResult Index()
        {
            // tạo viewbag
            // tạo list đồng hồ mới
            var lstQAM = db.SanPhams.Where(n => n.IdLoaiSanPham == 1 && n.DaXoa == false).ToList().OrderBy(n => n.DonGia);
            // gán vào viewbang
            ViewBag.lstQAM = lstQAM;
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
    }
}