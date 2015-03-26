using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBugTracker.Models
{
     public class IndexViewModel
    {
       // Type of Bug
         public List<Bug> buglist { get; set; }

         // Type of Task
        public List<Task> tasklist { get; set; }
    }
}