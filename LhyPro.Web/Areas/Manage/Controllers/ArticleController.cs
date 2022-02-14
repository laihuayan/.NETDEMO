using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LhyPro.Web.Areas.Manage.Controllers
{
    public class ArticleController : Controller
    {
        // 文章管理
        // GET: /Manage/Article/
        public ActionResult Index()
        {
            return View();
        }
	}
}