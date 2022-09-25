using project_spotonsepia.Class;
using project_spotonsepia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project_spotonsepia.Controllers
{
  
    public class AdminController : Controller
    {
        ServicesEntities db = new ServicesEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(tbl_admin ad)
        {
            tbl_admin a = db.tbl_admin.Where(x => x.ad_email == ad.ad_email && x.ad_password == ad.ad_password).SingleOrDefault();


            if (a != null)
            {
                Session["ad_email"] = a.ad_email;

                Session["ad_id"] = a.ad_id;

                return RedirectToAction("AdminDashboard");

            }

            else
            {
                ViewBag.error = "Invalid Name or Password";
            }

            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult SignUp() {

            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public ActionResult SignUp(tbl_customer model)
        {
            if (ModelState.IsValid) {
                var result = db.tbl_customer.Add(model);
                db.SaveChanges();
            }

            return View();
        }
    }
}