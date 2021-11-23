using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebToi_final_01.Models;

namespace WebToi_final_01.Controllers
{
    public class KiemTraController : Controller
    {
        private Shop context = new Shop();
        // GET: KiemTra
        public ActionResult Index()
        {
            var model = context.SanPhams.ToList();
            return View(model);
        }

        // GET: KiemTra/Details/5
        public ActionResult Details(string id)
        {
            var model =context.SanPhams.Find(id);
            return View(model);
        }

        // GET: KiemTra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KiemTra/Create
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

        // GET: KiemTra/Edit/5
        public ActionResult Edit(int id , DanhMuc danhMuc)
        {
            DanhMuc danhMuc_Edit = context.DanhMucs.Find(id);
            danhMuc_Edit.TenDM = danhMuc.TenDM;
            context.SaveChanges();
            return Redirect("/KiemTra/Details" + danhMuc.MaDM);


        }


        // POST: KiemTra/Edit/5
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

        // GET: KiemTra/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KiemTra/Delete/5
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
