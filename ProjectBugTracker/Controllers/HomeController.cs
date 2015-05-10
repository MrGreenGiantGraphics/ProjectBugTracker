using ProjectBugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectBugTracker.Controllers
{
    public class HomeController : Controller
    {
        // Private instance of SINGELTON
        private SingletonService _service;
        // Point to the Singleton instance
        public HomeController()
        {
            //_service = new SingletonService
            _service = SingletonService.Instance;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BugTest()
        {
            ViewBag.Message = "Hello Welcome to the Bug Pages.";

            IndexViewModel viewModel = new IndexViewModel();

            // Link to Type of WorkItem from Singleton-Service
            viewModel.workList = _service.fetchAllBugs();

            // This LINQ call will filter only BUGS from the Database
            List<WorkItem> tempList = _service.fetchAllBugs().Where(b => b.GetType().Name == "Bug").ToList();
            List<Bug> listOfBug = tempList.Cast<Bug>().ToList();
            viewModel.BugList = listOfBug;

            // This LINQ call will filter only TASK from the Database
            List<WorkItem> tempList2 = _service.fetchAllBugs().Where(t => t.GetType().Name == "Task").ToList();
            List<Task> listOfTask = tempList2.Cast<Task>().ToList();
            viewModel.tasklist = listOfTask;

            _service.Increment();
            viewModel.Count = _service.Counter;

            return View(viewModel);
        }

        public ActionResult Create()
        {
            CreateViewModel cvm = new CreateViewModel();
            cvm.Message = "Hello from the Create View Model.";
            cvm.Priority = new List<string>()
            {
                "Low",
                "Medium",
                "High"
            };

            return View(cvm);
        }
        [HttpPost]
        public ActionResult Create(CreateViewModel createVM)
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
    }
}