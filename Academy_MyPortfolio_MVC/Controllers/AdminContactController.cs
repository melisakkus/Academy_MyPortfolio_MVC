using Academy_MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC.Controllers
{
    public class AdminContactController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var contatcs = db.TblContacts.ToList();
            return View(contatcs);
        }

        public ActionResult DeleteContact(int id)
        {
            var contact = db.TblContacts.Find(id);
            db.TblContacts.Remove(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(TblContact newContact)
        {
            db.TblContacts.Add(newContact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var contact = db.TblContacts.Find(id);
            return View(contact);

        }

        [HttpPost]
        public ActionResult UpdateContact(TblContact newContact)
        {
            var contact = db.TblContacts.Find(newContact.ContactId);
            contact.Phone = newContact.Phone;
            contact.Email = newContact.Email;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}