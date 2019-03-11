using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;
using Microsoft.AspNet.Identity;

namespace TrashCollector.Controllers
{
    public class PickUpsController : Controller
    {
        ApplicationDbContext db;
        public PickUpsController()
        {
            db = new ApplicationDbContext();
        }
        // GET: PickUps
        public ActionResult Index()
        {
            return View();
        }

        // GET: PickUps/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PickUps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PickUps/Create
        [HttpPost]
        public ActionResult Create(PickUps pickUps)
        {
            try
            {
                var user = User.Identity.GetUserId();
                var customer = db.Customers.Where(c => c.ApplicationUserId == user).Single();
                pickUps.CustomerId = customer.Id;
                db.PickUps.Add(pickUps);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PickUps/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PickUps/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PickUps/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PickUps/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
