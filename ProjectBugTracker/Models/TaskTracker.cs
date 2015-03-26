using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBugTracker.Models
{
     public class TaskTracker
    {
         public static List<Task> GetTaskItem()
         {
             List<Task> TList = new List<Task>()
             {
                 new Task() { Text = "Call IT!", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Low, Description = "Call the IT department to make an appointment."},
                 new Task() { Text = "Update Server", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Medium, Description = "Update the server for the Database."},
                 new Task() { Text = "Fix Web Page!", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Low, Description = "Check directories for the web department."},
                 new Task() { Text = "Fix Dead Links!", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Low, Description = "Check webpage make sure links are working."},
                 new Task() { Text = "Button Issues!", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Low, Description = "Update the buttons on the Index page."}
             };

             return TList;
         }
    }
}