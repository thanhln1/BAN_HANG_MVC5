using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAN_HANG_MVC5.Models;

namespace BAN_HANG_MVC5.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        BanQuanAoEntities2 db = new BanQuanAoEntities2();
        [ChildActionOnly]
        public ActionResult SanPhamStyle1Partial()
        {
            return PartialView();
        }
    }
}