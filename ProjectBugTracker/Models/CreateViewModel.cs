using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBugTracker.Models
{
    public class CreateViewModel
    {
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public List<string> Priority { get; set; }
        public string StepsToReproduce { get; set; }
        public string Message { get; set; }
    }
}