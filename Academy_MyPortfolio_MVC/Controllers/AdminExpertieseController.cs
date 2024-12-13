using Academy_MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class AdminExpertieseController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var experties = db.TblExpertieses.ToList();
            return View(experties);
        }
        public ActionResult DeleteExpertiese(int id)
        {
            var experties = db.TblExpertieses.Find(id);
            db.TblExpertieses.Remove(experties);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateExpertiese(int id)
        {
            var experties = db.TblExpertieses.Find(id);
            return View(experties);
        }

        [HttpPost]
        public ActionResult UpdateExpertiese(TblExperties experties)
        {
            var value = db.TblExpertieses.Find(experties.ExpertiseId);
            value.Title = experties.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddExpertiese()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExpertiese(TblExperties experties)
        {
            db.TblExpertieses.Add(experties);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}