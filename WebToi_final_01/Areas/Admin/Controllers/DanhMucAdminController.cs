using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebToi_final_01.Areas.Admin.Controllers
{
    public class DanhMucAdminController : Controller
    {
        // GET: Admin/DanhMucAdmin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/DanhMucAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/DanhMucAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/DanhMucAdmin/Create
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

        // GET: Admin/DanhMucAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/DanhMucAdmin/Edit/5
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

        // GET: Admin/DanhMucAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/DanhMucAdmin/Delete/5
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
