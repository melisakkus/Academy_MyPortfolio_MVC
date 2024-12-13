using Academy_MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class AdminTestimonialController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var testimonial = db.TblTestimonials.ToList();
            return View(testimonial);
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var testimonial = db.TblTestimonials.Find(id);
            db.TblTestimonials.Remove(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTestimonial(TblTestimonial newTestimonial)
        {
            db.TblTestimonials.Add(newTestimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var testimonial = db.TblTestimonials.Find(id);
            return View(testimonial);

        }

        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial newTestimonial)
        {
            var testimonial = db.TblTestimonials.Find(newTestimonial.TestimonialId);
            testimonial.NameSurname = newTestimonial.NameSurname;
            testimonial.Title = newTestimonial.Title;
            testimonial.ImageUrl = newTestimonial.ImageUrl;
            testimonial.Comment = newTestimonial.Comment;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}