﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheFoody.DataAccess;

namespace TheFoody.Controllers
{
    public class HomeController : Controller
    {
        TheFoodyContext db = new TheFoodyContext();
        public ActionResult Index()
        {
            var cookie = Request.Cookies["Login"];
            if ((cookie != null) && (cookie.Value != ""))
            {
                Session["UserEmail"] = (cookie.Values["UserEmail"].ToString());
                if ((cookie.Values["FirstName"])!=null)
                {
                    Session["FirstName"] = (cookie.Values["FirstName"].ToString());
                    Session["LastName"] = (cookie.Values["LastName"].ToString());
                    Session["Phone"] = (cookie.Values["Phone"].ToString());
                    Session["Photo"] = (cookie.Values["Photo"].ToString());
                    Session["Address"] = (cookie.Values["Address"].ToString());
                    Session["City"] = (cookie.Values["City"].ToString());
                    Session["PostCode"] = (cookie.Values["PostCode"].ToString());
                    Session["District"] = (cookie.Values["District"].ToString());
                    Session["UserType"] = (cookie.Values["UserType"].ToString());
                    Session["Status"] = (cookie.Values["Status"].ToString());
                }
            }
            if (Session["UserEmail"] == null)
            {
                Session["ReviewHtml"] = "<!-- -->";
                Session["FirstName"] = "";
                Session["LastName"] = "";
                Session["Phone"] = "0111234567";
                Session["Photo"] = "Not Set Yet";
                Session["Address"] = "Not Set Yet";
                Session["City"] = "Not Set Yet";
                Session["PostCode"] = 00000;
                Session["District"] = "Not Set Yet";
                Session["UserType"] = "Admin";
                Session["Status"] = "Active";

            }
            return View();
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

        public JsonResult getData(string term)
        {


            List<string> citylist = (from list in db.Restaurants
                                     select list.City).ToList();

            // Select the tags that match the query, and get the 
            // number or tags specified by the limit.

            List<string> getValues = citylist.Where(item => item.ToLower().StartsWith(term.ToLower())).ToList();

            // Return the result set as JSON
            return Json(getValues, JsonRequestBehavior.AllowGet);
        }
    }
}