using Academy_MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class AdminAboutController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var abouts = db.TblAbouts.ToList();
            return View(abouts);
        }
        public ActionResult DeleteAbout(int id)
        {
            var about = db.TblAbouts.Find(id);
            db.TblAbouts.Remove(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var about = db.TblAbouts.Find(id);
            return View(about);
        }

        [HttpPost]
        public ActionResult UpdateAbout(TblAbout newAbout)
        {
            var about = db.TblAbouts.Find(newAbout.AboutId);
            about.ImageUrl = newAbout.ImageUrl;
            about.Title = newAbout.Title;   
            about.Description = newAbout.Description;
            about.CvUrl = newAbout.CvUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbout(TblAbout model)
        {
            db.TblAbouts.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}