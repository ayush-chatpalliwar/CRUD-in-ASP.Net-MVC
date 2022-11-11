using CRUD_in_ASP.Net_MVC.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_in_ASP.Net_MVC.Models;

namespace CRUD_in_ASP.Net_MVC.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDBContext db = new ApplicationDBContext();

        public ActionResult Index()
        {
            return View(db.Rec.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Recruitment model)
        {
            db.Rec.Add(model);
            db.SaveChanges();
            ViewBag.Message = "Data Insert Successfully";
            return View();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = db.Rec.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Recruitment Model)
        {
            var data = db.Rec.Where(x => x.Id == Model.Id).FirstOrDefault();
            if (data != null)
            {
                data.Name = Model.Name;
                data.Age = Model.Age;
                data.Gender = Model.Gender;
                data.Language = Model.Language;
                data.Experience = Model.Experience;
                data.Mobile = Model.Mobile;
                data.Email = Model.Email;

                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var data = db.Rec.Where(x => x.Id == id).FirstOrDefault();
            db.Rec.Remove(data);
            db.SaveChanges();
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}