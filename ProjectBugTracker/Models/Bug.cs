using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBugTracker.Models
{
      public class Bug : WorkItem 
    {
        public string StepsToReproduce { get; set; }
        public Bug()
        { 
        }
        public Bug(string Text, DateTime DateCreated, BugTypes Priority, string StepsToReproduce)
            : base(Text, DateCreated, Priority)
        {
            this.StepsToReproduce = StepsToReproduce;        
        }

    }
}