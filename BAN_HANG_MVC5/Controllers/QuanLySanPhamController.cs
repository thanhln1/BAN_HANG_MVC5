using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAN_HANG_MVC5.Models;

namespace BAN_HANG_MVC5.Controllers
{
    public class QuanLySanPhamController : Controller
    {
        BanQuanAoEntities2 db = new BanQuanAoEntities2();
        // GET: QuanLySanPham
        public ActionResult Index()
        {
            return View(db.SanPhams.Where(n => n.DaXoa == false).OrderByDescending(n => n.IdSanPham));
        }
    }
}