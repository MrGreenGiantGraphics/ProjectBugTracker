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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bugs()
        {
            ViewBag.Message = "Hello welcome to the Bug Pages.";

            IndexViewModel viewModel = new IndexViewModel();


            var trackTask = TaskTracker.GetTaskItem();
            var trackBug = BugTracker.GetBugItem();

            var newList = trackTask.Where(T => T.Priority == WorkItem.BugTypes.Low).ToList();
            var taskList = trackTask.Where(T => T.DateCreated >= DateTime.Now).ToList();
            var bugList = trackBug.Where(B => B.DateCreated >= DateTime.Now).ToList();

            viewModel.tasklist = taskList;
            viewModel.buglist = bugList;

          return View(viewModel);
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