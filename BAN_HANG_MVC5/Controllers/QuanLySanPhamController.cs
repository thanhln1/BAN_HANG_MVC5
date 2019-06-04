using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        [HttpGet]
        public ActionResult TaoMoiSanPham()
        {
            //  load dropdownlist
            ViewBag.IdMLSP = new SelectList(db.MaLoaiSanPhams.OrderBy(n => n.TenLSP),"IdMLSP", "TenLSP");
            ViewBag.IdLoaiSanPham = new SelectList(db.LoaiSanPhams.OrderBy(n => n.IdLoaiSanPham), "IdLoaiSanPham", "TenLoai");
            return View();
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult TaoMoiSanPham(SanPham sanpham, HttpPostedFileBase[] HinhAnh)
        {
            ViewBag.IdMLSP = new SelectList(db.MaLoaiSanPhams.OrderBy(n => n.TenLSP), "IdMLSP", "TenLSP");
            ViewBag.IdLoaiSanPham = new SelectList(db.LoaiSanPhams.OrderBy(n => n.IdLoaiSanPham), "IdLoaiSanPham", "TenLoai");
            db.SanPhams.Add(sanpham);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult XoaSanPham(int? IdSamPham)
        {
            if (IdSamPham == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            SanPham sanpham = db.SanPhams.SingleOrDefault(n => n.IdSanPham == IdSamPham);
            if(sanpham==null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMLSP = new SelectList(db.MaLoaiSanPhams.OrderBy(n => n.TenLSP), "IdMLSP", "TenLSP", sanpham.IdSanPham);
            ViewBag.IdLoaiSanPham = new SelectList(db.LoaiSanPhams.OrderBy(n => n.IdLoaiSanPham), "IdLoaiSanPham", "TenLoai" ,sanpham.IdLoaiSanPham);
            return View(sanpham);
        }



        [HttpPost]
        public ActionResult XoaSanPham(int IdSanPham)
        {
            if(IdSanPham == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanpham = db.SanPhams.SingleOrDefault(n => n.IdSanPham == IdSanPham);
            if(sanpham == null)
            {
                return HttpNotFound();
            }

            db.SanPhams.Remove(sanpham);
            db.SaveChanges();
            return View(IdSanPham);
        }



    }
}