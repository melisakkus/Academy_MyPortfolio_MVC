﻿using Academy_MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class ProjectController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();

        private void CategoryDropDown()
        {
            var categoryList = db.TblCategories.ToList();
            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.categories = categories;
        }

        public ActionResult Index()
        {
            var projects = db.TblProjects.ToList();
            return View(projects);
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
            CategoryDropDown();
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(TblProject model)
        {
            CategoryDropDown();
            if (!ModelState.IsValid) //eğer model şartlara uymuyorsa
            {
                return View(model);
            }
            db.TblProjects.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProject(int id)
        {
            var value = db.TblProjects.Find(id);
            db.TblProjects.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            CategoryDropDown();
            var value = db.TblProjects.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProject(TblProject model)
        {
            CategoryDropDown();
            var value = db.TblProjects.Find(model.ProjectId); //modelden gelen id'ye göre değerleri bulduk
            value.Name = model.Name; //değerleri değiştiriyoruz
            value.ImageUrl = model.ImageUrl;
            value.Description = model.Description;
            value.CategoryId = model.CategoryId;
            value.GithubUrl = model.GithubUrl;

            if (!ModelState.IsValid) //eğer model şartlara uymuyorsa
            {
                return View(model);
            }

            db.SaveChanges(); //değerler validasyondan geçerse değişiklikleri kaydet
            return RedirectToAction("Index");
        }
    }
}