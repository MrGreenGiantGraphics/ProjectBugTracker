using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBugTracker
{
    public abstract class WorkItem 
    {
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public BugTypes Priority { get; set; }
        public enum BugTypes
        {
            High,
            Medium,
            Low

        }

    }
}