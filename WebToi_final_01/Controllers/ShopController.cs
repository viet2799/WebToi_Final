using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebToi_final_01.Models;

namespace WebToi_final_01.Controllers
{
    public class ShopController : Controller
    {
        private Shop con = new Shop();
        // GET: Shop
        public ActionResult Index()
        {
            var model = con.SanPhams.ToList();
            return View(model);
        }
        public ActionResult DMSP(int id)
        {
            var model = con.SanPhams.Where(x => x.MaDM == id).ToList();
            return View(model);
        }

        // GET: Shop/Details/5
        public ActionResult Details(string id)
        {
            var model = con.SanPhams.Find(id);
            return View(model);
        }

        // GET: Shop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shop/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shop/Edit/5
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

        // GET: Shop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shop/Delete/5
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
