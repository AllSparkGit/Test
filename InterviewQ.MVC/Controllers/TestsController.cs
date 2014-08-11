using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewQ.MVC.Models;

namespace InterviewQ.MVC.Controllers
{
    public class TestsController : Controller
    {
        // GET: Tests
        public ActionResult Index()
        {
            var model = _testColletion.OrderBy(r => r.TestName);
            return View(model);
        }

        private static List<TestModel> _testColletion = new List<TestModel>()
        {
            new TestModel()
            {
                TestID = 1,
                TestName = "ASP.NET",
            },
            new TestModel()
            {
                TestID = 2,
                TestName = "ASP.NET MVC",
            },
            new TestModel()
            {
                TestID = 3,
                TestName = "ASP.NET Spring",
            },
            new TestModel()
            {
                TestID = 4,
                TestName = ".NET C#",
            }
        };
    }
}
