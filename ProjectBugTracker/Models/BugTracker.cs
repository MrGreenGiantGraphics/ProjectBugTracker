using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBugTracker.Models
{
     public class BugTracker
    {
         public static List<Bug> GetBugItem()
         {
             List<Bug> BList = new List<Bug>()
             {
                 new Bug() { Text = "Sorry you have entered the wrong value.", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Low, StepsToReproduce = "Try to enter the right value."},
                 new Bug() { Text = "Data is not reaching the database.", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.High, StepsToReproduce = "Place data into field."},
                 new Bug() { Text = "Web Page is not loading correctly.", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Medium, StepsToReproduce = "Load the Index page and refresh."},
                 new Bug() { Text = "Dead link no data returning.", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.High, StepsToReproduce = "Do a search for the data set."},
                 new Bug() { Text = "Button is not responding.", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Medium, StepsToReproduce = "Click the button."},

             };

             return BList;
         }
    }
}