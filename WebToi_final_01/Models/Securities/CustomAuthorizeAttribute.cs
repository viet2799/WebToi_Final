
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebToi_final_01.Models;

namespace WebToi_final_01.Models
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            /// k có session => về trang login
            if (HttpContext.Current == null)
            {
                //filterContext.Result = new RedirectToRouteResult(
                //         new System.Web.Routing.RouteValueDictionary(
                //          new { Controller = "Login", Action = "Index", 
                //              ReturnUrl = filterContext.HttpContext.Request.RawUrl }));
                filterContext.Result = new RedirectResult("~/Login/Index?ReturnUrl="+ filterContext.HttpContext.Request.RawUrl);
                return;
            }
            var acc = (Account)HttpContext.Current.Session["Account"];
            
            if (acc==null)
            {
                //  filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { Controller = "Account", Action = "Index" }));
                //filterContext.Result = new RedirectToRouteResult(
                //    new System.Web.Routing.RouteValueDictionary(
                //        new { Controller = "Login", Action = "Index",
                //            ReturnUrl = filterContext.HttpContext.Request.RawUrl}));
                filterContext.Result = new RedirectResult("~/Login/Index?ReturnUrl=" + filterContext.HttpContext.Request.RawUrl);

            }
            else
            {               
                CustomPrincipal cp = new CustomPrincipal(acc);
                if (!cp.IsInRole(Roles))
                {
                    //filterContext.Result = new RedirectToRouteResult(
                    //    new System.Web.Routing.RouteValueDictionary(
                    //        new { Controller = "Login", Action = "Index" }));
                    filterContext.Result = new RedirectResult("~/Login/Index?ReturnUrl=" + filterContext.HttpContext.Request.RawUrl);

                }
            }
        }
    }
}