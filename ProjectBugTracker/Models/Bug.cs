using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBugTracker.Models
{
      public class Bug : WorkItem 
    {
          public string StepsToReproduce { get; set; }  
    }
}