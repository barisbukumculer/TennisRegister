using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TennisRegister.Models.Entity;

namespace TennisRegister.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        WebMvcDBEntities db = new WebMvcDBEntities();
        public ActionResult Index()
        {
            List<SelectListItem> values = (from i in db.TBLSEHIR.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.SEHIR,
                                               Value = i.ID.ToString(),
                                           }).ToList();
            ViewBag.Vls = values;
            return View();
        }
    }
}