using Cloud.GoogleDrive.WebApplication.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cloud.GoogleDrive.WebApplication.Controllers
{
    public class CloudController : Controller
    {
        // GET: Cloud
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file != null)
            {
                GoogleDriveAPIHelper.UplaodFileOnDrive(file);
                ViewBag.Success = "File Uploaded on Google Drive";
                return View();
            }
            ViewBag.Failed = "something went wrong.";
            return View();
        }
    }
}