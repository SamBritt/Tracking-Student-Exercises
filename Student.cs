using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student : NSSPerson
    {
        public Student(string firstName, string lastName, Cohort cohort)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.currentCohort = cohort;
        }

        // public string firstName { get; set; }
        // public string lastName { get; set; }

        // private string slackHandle { get; set; }

        // public Cohort currentCohort { get; set; }

        // public string getSlackHandle()
        // {
        //     return slackHandle;
        // }

        public List<Exercise> exercises = new List<Exercise>();

    }
}