using MVC_work_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_work_1.Controllers
{
    public class 客戶資料清單Controller : Controller
    {
		private 客戶資料Entities db = new 客戶資料Entities();

		// GET: 客戶資料清單
		public ActionResult Index()
        {
			var data = db.客戶清單;
			return View(data);
		}
    }
}