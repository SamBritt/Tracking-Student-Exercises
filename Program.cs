using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {


            Exercise exercise1 = new Exercise("Array Methods", "Javascript");
            Exercise exercise2 = new Exercise("Loops", "C#");
            Exercise exercise3 = new Exercise("Hash Functions", "Python");
            Exercise exercise4 = new Exercise("Gradient Descent", "C");

            Cohort cohort30 = new Cohort("Cohort 30");
            Cohort cohort31 = new Cohort("Cohort 31");
            Cohort cohort29 = new Cohort("Cohort 29");

            Student student1 = new Student("Samuel", "Britt", cohort30);
            Student student2 = new Student("James", "McKoy", cohort29);
            Student student3 = new Student("Alex", "Trumon", cohort31);
            Student student4 = new Student("Billy", "Mitchell", cohort30);

            Instructor instructor1 = new Instructor("Kristen", "Norris");
            Instructor instructor2 = new Instructor("Andy", "Collins");
            Instructor instructor3 = new Instructor("Jisie", "David");

            cohort29.addInstructor(instructor1);
            cohort30.addInstructor(instructor2);
            cohort31.addInstructor(instructor3);

            instructor1.assignExercise(student1, exercise1);
            instructor1.assignExercise(student3, exercise3);
            instructor2.assignExercise(student2, exercise1);
            instructor2.assignExercise(student4, exercise2);
            instructor3.assignExercise(student2, exercise4);
            instructor3.assignExercise(student1, exercise3);

            //For testing
            List<Exercise> exercises = new List<Exercise>{
                exercise1, exercise2, exercise3, exercise4
            };
            List<Student> students = new List<Student>{
                student1, student2, student3, student4
            };

            foreach (Student person in students)
            {
                Console.WriteLine($"{person.firstName + " " + person.lastName} is working on:");
                Console.WriteLine("--------");
                foreach (Exercise assignment in person.exercises)
                {


                    Console.WriteLine($"{assignment.name} in {assignment.language}");
                    Console.WriteLine();
                    
                }
                Console.WriteLine("^^^^^^^^^");
            }

        }
    }
}
