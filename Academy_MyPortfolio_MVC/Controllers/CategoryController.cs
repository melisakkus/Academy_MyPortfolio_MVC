using Academy_MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class CategoryController : Controller
    {

        //kategorileri listelemek istiyorum
        //ManageNuGetPacakages/Browse/EntityFramework indirelim
        MyPortfolioDbEntities db = new MyPortfolioDbEntities(); //EntityFramework dahil edelim

        public ActionResult Index() //listeleme
        {
            var values = db.TblCategories.ToList();//Tbl.Categories sınıfını bize listeler
            return View(values);
        }

        [HttpGet] //sayfayı getirecek
        public ActionResult CreateCategory()
        {
            return View();  
        }

        [HttpPost] //butona tıklayınca tetiklenecek olan kısım
        public ActionResult CreateCategory(TblCategory category)
        {
            db.TblCategories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index"); //Index sayfasına geri dönelim
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = db.TblCategories.Find(id);
            db.TblCategories.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id) 
        {
            var value = db.TblCategories.Find(id);
            return View(value);
        }

        [HttpPost] 
        public ActionResult UpdateCategory(TblCategory model) 
        {
            var value = db.TblCategories.Find(model.CategoryId);
            value.Name = model.Name;
            db.SaveChanges();
            return RedirectToAction("Index");   
            
        }
    }
}