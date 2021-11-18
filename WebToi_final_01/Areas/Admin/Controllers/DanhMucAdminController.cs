using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebToi_final_01.Models;

namespace WebToi_final_01.Areas.Admin.Controllers
{
    public class DanhMucAdminController : Controller
    {
        // GET: Admin/DanhMucAdmin
        public ActionResult Index()
        {
            using (var con = new Shop())
            {
                var model = con.DanhMucs.ToList();
                return View(model);
            }
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
        public ActionResult Create(DanhMuc model)
        {
            try
            {
                // TODO: Add insert logic here

                using (var con = new Shop())
                {
                    con.DanhMucs.Add(model);
                    con.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/DanhMucAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            using (var con = new Shop())
            {
                var model = con.DanhMucs.Find(id);

                return View(model);
            }
        }

        // POST: Admin/DanhMucAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(DanhMuc model)
        {
            try
            {
                using (var con = new Shop())
                {
                    var obj = con.DanhMucs.Find(model.MaDM);
                    obj.TenDM = model.TenDM;

                    con.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return Redirect("/Admin/DanhMucAd/Edit/" + model.MaDM);
            }
        }

        // GET: Admin/DanhMucAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            using (var con = new Shop())
            {
                var model = con.DanhMucs.Find(id);

                return View("Edit", model);
            }
        }

        // POST: Admin/DanhMucAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(DanhMuc model)
        {
            try
            {
                // TODO: Add delete logic here

                using (var con = new Shop())
                {
                    var obj = con.DanhMucs.Find(model.MaDM);
                    con.DanhMucs.Remove(obj);

                    con.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
