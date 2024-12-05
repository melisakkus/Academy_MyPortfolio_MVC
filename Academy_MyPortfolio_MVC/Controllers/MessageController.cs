using Academy_MyPortfolio_MVC.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.TblMessages.Where(x=>x.IsRead == false).ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = db.TblMessages.Find(id);
            db.TblMessages.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MessageDetail(int? id)
        {
            var message = db.TblMessages.Find(id);
            message.IsRead = true;
            db.SaveChanges();
            return View(message);
        }

        //[HttpPost]
        //public ActionResult MakeMessageRead(int id)
        //{
        //    var message = db.TblMessages.Find(id);
        //    message.IsRead = true;
        //    db.SaveChanges();
        //    return PartialView(message);
        //}
    }
}