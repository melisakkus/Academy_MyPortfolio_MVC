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
        public ActionResult UpdateAbout(TblAbout model)
        {
            var about = db.TblAbouts.Find(model.AboutId);

            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory; //projenin dosya yolunu alır
                //C:\Users\90505\source\repos\Academy_MyPortfolio_MVC\Academy_MyPortfolio_MVC
                var saveLocation = currentDirectory + "CvImages\\Images\\"; //resmin kaydedileceği yer
                var fileName = Path.Combine(saveLocation, model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                about.ImageUrl = "/CvImages/Images/" + model.ImageFile.FileName;
            }

            if (model.PdfFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "CvImages\\CV\\";
                var fileName = Path.Combine(saveLocation, model.PdfFile.FileName);
                model.PdfFile.SaveAs(fileName);
                about.CvUrl = "/CvImages/CV/" + model.PdfFile.FileName;
            }

            about.Title = model.Title;   
            about.Description = model.Description;
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
            if(model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "CvImages\\Images\\";
                var fileName = Path.Combine(saveLocation, model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/CvImages/Images/" + model.ImageFile.FileName;
            }
            db.TblAbouts.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}