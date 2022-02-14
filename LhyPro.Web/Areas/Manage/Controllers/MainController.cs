using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LhyPro.Web.Areas.WebManage.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /WebManage/Main/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Header()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult Footer()
        {
            return View();
        }
	}
}