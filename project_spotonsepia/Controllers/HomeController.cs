using project_spotonsepia.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace project_spotonsepia.Controllers
{
    public class HomeController : Controller 
    {
        ServicesEntities db = new ServicesEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Services()
        {


            return View();
        }
       

        public ActionResult Portfolio()
        {


            return View();
        }

        public ActionResult ComingSoon()
        {


            return View();
        }


        public ActionResult blank()
        {


            return View();
        }

        public ActionResult UploadImage(ContentViewModel model) 
        {
            var file = Request.Files["file"];
            if (ModelState.IsValid)
            {
                try
                {


                    if (file != null)
                    {
                        string path = Path.Combine(Server.MapPath("~/Content/Upload"), Path.GetFileName(file.FileName));
                        file.SaveAs(path);

                        var customermodel = new tbl_customer 
                        {
                             cus_email = model.email,
                             Name = model.Name,
                             cus_password = model.password,
                             last_name = model.lastname,
                             Dob = Convert.ToDateTime(model.Dob),
                             Gender = model.Gender,
                             contact = model.contact,
                             cus_address = model.cus_address,
                             ad_id_fk = model.ad_id_fk,
                             cus_imge = path
                        };

                        var result = db.tbl_customer.Add(customermodel);
                        db.SaveChanges();
                        model.file = path;
                    }
                    ViewBag.FileStatus = "File uploaded successfully.";
                }
                catch (Exception ex)
                {

                    ViewBag.FileStatus = "Error while file uploading.";
                }

            }
            return View("Portfolio", model);
        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }
        public ActionResult RetrieveImage(string email)
        {
            string path = GetImageFromDataBase(email);
            if (path != null)
            {
                return base.File(path, "image/jpg");
            }
            else
            {
                return null;
            }
        }
        public string GetImageFromDataBase(string email)
        {
            var q = from temp in db.tbl_customer where temp.cus_email == email select temp.cus_imge;
            string path = q.FirstOrDefault();
            return path;
        }
    }
}