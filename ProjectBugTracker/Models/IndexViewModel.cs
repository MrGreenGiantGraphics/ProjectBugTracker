using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBugTracker.Models
{
     public class IndexViewModel
    {


        // Type of WorkItem
         public List<WorkItem> workList { get; set; }

        // Type of Bug
        public List<Bug> BugList { get; set; }

        // Type of Task
        public List<Task> tasklist { get; set; }

         // Show the counter
         public int Count { get; set; }

    }
}