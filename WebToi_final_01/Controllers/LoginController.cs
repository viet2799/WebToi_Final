using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebToi_final_01.Models;


namespace WebToi_final_01.Controllers
{
    public class LoginController : Controller
    {
        private Shop con = new Shop();
        // GET: Login
        public ActionResult Index(Account model, string ReturnUrl)
        {
            var user = con.NguoiDungs
                    .Where(x => x.UserName == model.UserName && x.PassWord == model.Password)
                    .FirstOrDefault();
            if (user != null)
            {
                model.Roles = (from a in con.Roles
                               join b in con.UserInRoles
                               on a.IDRole equals b.IDRole
                               where (a.RoleName != null && b.UserName.Equals(model.UserName))
                               select a.RoleName).ToList();
                Session["Account"] = model;
                if (string.IsNullOrEmpty(ReturnUrl))
                {
                    return Redirect("/Shop/Index");
                }
                else
                {
                    return Redirect(ReturnUrl);
                }
            }
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
