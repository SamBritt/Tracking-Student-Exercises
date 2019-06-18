using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public Student(string firstName, string lastName, Cohort cohort)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.CurrCohort = cohort;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }

        private string slackHandle { get; set; }

        public Cohort CurrCohort { get; set; }

        public string getSlackHandle()
        {
            return slackHandle;
        }

        public List<Exercise> exercises = new List<Exercise>();

    }
}