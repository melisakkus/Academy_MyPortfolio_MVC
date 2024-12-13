using Academy_MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class AdminSocialMediaController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var socialMedias = db.TblSocialMedias.ToList();
            return View(socialMedias);
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var socialMedia = db.TblSocialMedias.Find(id);
            db.TblSocialMedias.Remove(socialMedia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var socialMedia = db.TblSocialMedias.Find(id);
            return View(socialMedia);
        }

        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia socialMedia)
        {
            var social = db.TblSocialMedias.Find(socialMedia.SocialMediaId);
            social.Name = socialMedia.Name;
            social.Url = socialMedia.Url;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSocialMedia(TblSocialMedia social)
        {
            db.TblSocialMedias.Add(social);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}