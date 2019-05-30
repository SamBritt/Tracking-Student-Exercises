using System;
using System.Collections.Generic;
namespace StudentExercises
{

    class Cohort
    {
        public Cohort(string cohortName)
        {
            this.name = cohortName;  
        }
        public string name { get; set; }

        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        List<Instructor> instructors = new List<Instructor>();

        public void addInstructor(Instructor instructor){
            instructors.Add(instructor);
        }

    }
}