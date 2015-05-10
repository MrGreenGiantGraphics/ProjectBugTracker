using ProjectBugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBugTracker
{
    //Singleton
    public class SingletonService
    {
        private int _counter;
        // holds all bugs and tasks
        private List<WorkItem> _allBugs;

        // Internal Variable to hold variables.
        private static SingletonService _instance = null;

        // Instance of the Singleton
        public static SingletonService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonService();
                }
                return _instance;
            }
        }

        // THE CONSTRUCTOR
        private SingletonService()
        {
            _counter = 10;
            // Create a list of objects from the List of type <WorkItem> 
            _allBugs = new List<WorkItem>()
            {
                  new Bug() { Text = "Sorry you have entered the wrong values.", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Low, StepsToReproduce = "Try to enter the right value."},
                 new Bug() { Text = "Data is not reaching the database.", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.High, StepsToReproduce = "Place data into field."},
                 new Bug() { Text = "Button is not responding.", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Medium, StepsToReproduce = "Click the button."},
                  new Task() { Text = "Call IT!", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Low, Description = "Call the IT department to make an appointment."},
                 new Task() { Text = "Update Server", DateCreated=DateTime.Now, Priority = WorkItem.BugTypes.Medium, Description = "Update the server for the Database."}
            };

        }

        // Public Counter PROP - Talks to the Private _counter
        public int Counter
        {
            get
            {
                return _counter;
            }
            set
            {
                _counter = value;
            }

        }
        public void Increment()
        {
            _counter++;
        }
        // Fetch all the Bugs

        public List<WorkItem> fetchAllBugs()
        {
            return _allBugs;
        }

        // Post to List from CREATE

        public void Create(Bug createBug)
        {
            _allBugs.Add(createBug);
        }
    }
}