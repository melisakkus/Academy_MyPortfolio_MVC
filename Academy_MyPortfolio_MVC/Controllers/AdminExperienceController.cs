using Academy_MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class AdminExperienceController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var experiences = db.TblExperiences.ToList();
            return View(experiences);
        }
        public ActionResult DeleteExperience(int id)
        {
            var experience = db.TblExperiences.Find(id);
            db.TblExperiences.Remove(experience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var experience = db.TblExperiences.Find(id);
            return View(experience);
        }

        [HttpPost]
        public ActionResult UpdateExperience(TblExperience experience)
        {
            var value = db.TblExperiences.Find(experience.ExperienceId);
            value.CompanyName = experience.CompanyName;
            value.Title = experience.Title;
            value.StartDate= experience.StartDate;
            value.EndDate = experience.EndDate;
            value.Description = experience.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(TblExperience experience)
        {
            db.TblExperiences.Add(experience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}