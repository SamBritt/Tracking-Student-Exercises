using System;

namespace StudentExercises
{

    public class Instructor : NSSPerson
    {
        public Instructor(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // public string firstName { get; set; }
        // public string lastName { get; set; }
        // private string slackHandle { get; set; }
        private string specialty { get; set; }

        // public string getSlackHandle()
        // {
        //     return slackHandle;
        // }
        public string getSpeciality()
        {
            return specialty;
        }
        // public Cohort currentCohort { get; set; }

        public void assignExercise(Student student, Exercise exercise)
        {
            student.exercises.Add(exercise);
        }
    }
}