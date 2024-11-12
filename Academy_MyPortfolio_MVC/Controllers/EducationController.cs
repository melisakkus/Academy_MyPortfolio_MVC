using Academy_MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class EducationController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var educations = db.TblEducations.ToList();
            return View(educations);
        }

        public ActionResult DeleteEducation(int id)
        {
            var education = db.TblEducations.Find(id);
            db.TblEducations.Remove(education);

            var educatio2n = db.TblEducations.FirstOrDefault(x=>x.EducationId == id);


            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEducation(TblEducation model)
        {
            db.TblEducations.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
            //return RedirectToAction(nameof(Index)); ile de yazılabilir
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var education = db.TblEducations.Find(id);
            return View(education);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducation model)
        {
            var education = db.TblEducations.Find(model.EducationId);
            education.SchoolName = model.SchoolName;
            education.DepartmentName = model.DepartmentName;
            education.StartDate = model.StartDate;
            education.EndDate = model.EndDate;
            education.Description = model.Description;
            education.Degree = model.Degree;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}