using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;


namespace JqDt.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
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

		[HttpPost]
		public ActionResult GetData()
		{
			List<test> LstTest = new List<test>();
			LstTest.Add(new test() { sid="1",sname="Asker",pos="husband"});
			LstTest.Add(new test() { sid = "2", sname = "Haru", pos = "wife" });
			LstTest.Add(new test() { sid = "3", sname = "Spring", pos = "child" });

			JavaScriptSerializer jss = new JavaScriptSerializer();

			string Jstr = jss.Serialize(LstTest);

			return Json(Jstr);
		}

		public class test
		{
			public string sid { set; get; }
			public string sname { set; get; }
			public string pos { set; get; }
		}

	}
}