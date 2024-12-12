using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Academy_MyPortfolio_MVC;
using Academy_MyPortfolio_MVC.Models;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class AdminBannerController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var banners = db.TblBanners.ToList();
            return View(banners);
        }

        public ActionResult BannerDelete(int id)
        {
            var banner = db.TblBanners.Find(id);
            db.TblBanners.Remove(banner);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult BannerUpdate(int id) 
        {
            var banner = db.TblBanners.Find(id);
            return View(banner);
        }

        [HttpPost]
        public ActionResult BannerUpdate(TblBanner newBanner)
        {
            var banner = db.TblBanners.Find(newBanner.BannerId);
            banner.Title = newBanner.Title;
            banner.Description = newBanner.Description;
            banner.IsShown = newBanner.IsShown;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult NewBanner()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBanner(TblBanner newBanner)
        {
            db.TblBanners.Add(newBanner);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BannerIsShown(int id)
        {
            var banner = db.TblBanners.Find(id);
            banner.IsShown = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BannerIsNotShown(int id)
        {
            var banner = db.TblBanners.Find(id);
            banner.IsShown = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}