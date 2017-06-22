using onlineshop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace onlineshop.Controllers
{
    public class UploadController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Uploadmulti(IEnumerable<HttpPostedFileBase> files) {
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file.FileName);
                string contentType = MimeMapping.GetMimeMapping(fileName);

                if (file.ContentLength > 0 && contentType!="text/plain" )
                {
                    
                    var path = Path.Combine(Server.MapPath("~/App_Data/products"), fileName);
                    file.SaveAs(path);
                           
                }

            }

            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}