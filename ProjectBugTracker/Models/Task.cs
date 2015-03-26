using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ProjectBugTracker.Models

{
      public class Task : WorkItem 
    { 
        public string Description { get; set; }
        public Task()
        { 
        }
        public Task(string Text, DateTime DateCreated, BugTypes Priority, string Description)
            : base(Text, DateCreated, Priority)
                          
        {
            this.Description = Description;  
        }
    }
}