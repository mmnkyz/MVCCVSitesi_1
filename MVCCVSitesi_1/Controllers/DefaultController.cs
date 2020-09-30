using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCVSitesi_1.Models.Entities;

namespace MVCCVSitesi_1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        DBMVCCVEntities db = new DBMVCCVEntities();
        public ActionResult Index()
        {
            var bilgiler = db.TBLHAKKIMDA.ToList();
            return View(bilgiler);
        }
    }
}