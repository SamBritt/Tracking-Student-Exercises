using System;
using System.Collections.Generic;
using System.Linq;

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
            
            instructor1.currentCohort = cohort29;
            instructor2.currentCohort = cohort30;
            instructor3.currentCohort = cohort31;
            

            cohort29.addInstructor(instructor1);
            cohort30.addInstructor(instructor2);
            cohort31.addInstructor(instructor3);

            cohort29.AddStudent(student1);
            cohort30.AddStudent(student2);
            cohort31.AddStudent(student3);
            cohort29.AddStudent(student4);

            instructor1.assignExercise(student2, exercise1);
            instructor2.assignExercise(student2, exercise2);
            instructor2.assignExercise(student4, exercise2);
            instructor3.assignExercise(student2, exercise4);
            instructor3.assignExercise(student1, exercise3);
            instructor3.assignExercise(student1, exercise2);

            //For testing
            List<Exercise> exercises = new List<Exercise>{
                exercise1, exercise2, exercise3, exercise4
            };
            List<Student> students = new List<Student>{
                student1, student2, student3, student4
            };
            List<Instructor> instructors = new List<Instructor>{
                instructor1, instructor2, instructor3
            };
            List<Cohort> cohorts = new List<Cohort>{
                cohort29, cohort30, cohort31
            };
            //PT1
            List<Exercise> javascriptEx = exercises.Where(ex => ex.language == "Javascript").ToList();
            foreach (Exercise ex in javascriptEx)
            {
                Console.WriteLine($"{ex.name} in {ex.language}");
            }
            Console.WriteLine("*--*--*--*--*--*");
            //PT2
            List<Cohort> cohortStudents = cohorts.Where(coh => coh.name == "Cohort 29").ToList();
            foreach (Cohort coh in cohortStudents)
            {
                foreach(Student stu in coh.students){
                    Console.WriteLine(stu.firstName);
                }
            }
            Console.WriteLine("*--*--*--*--*--*");
            //PT3
            List<Instructor> instructorPerCoh = instructors.Where(ins => ins.currentCohort.name == "Cohort 29").ToList();
            foreach(Instructor inst in instructorPerCoh){
                Console.WriteLine($"Instructors for Cohort 29: {inst.firstName}");
            }
            Console.WriteLine("*--*--*--*--*--*");
            //PT4
            IEnumerable<Student> ascStudents = from student in students
            orderby student.lastName ascending
            select student;

            Console.WriteLine("Student's last names sorted.");
            foreach(Student stu in ascStudents){
                Console.WriteLine($"{stu.firstName} {stu.lastName}");
            }
            Console.WriteLine("*--*--*--*--*--*");
            //PT5
            Console.WriteLine("Students not working on exercises: ");
            foreach(Student stu in students){
                if(stu.exercises.Count == 0){
                    Console.WriteLine($"{stu.firstName} {stu.lastName}");
                }
            }
            Console.WriteLine("*--*--*--*--*--*");
            //PT6
            Student stuWithTheMost = student1;
            Console.WriteLine("Student with the most exercises: ");
            foreach(Student stu in students){
                if(stuWithTheMost.exercises.Count < stu.exercises.Count){
                    stuWithTheMost = stu;
                }
            }
            Console.WriteLine(stuWithTheMost.firstName);
            Console.WriteLine("*--*--*--*--*--*");
            //PT7
            foreach(Cohort coh in cohorts){
                Console.WriteLine($"Students in {coh.name}: ");
                foreach(Student stu in coh.students){
                    Console.WriteLine($" {stu.firstName} {stu.lastName}");
                }
            }
            // foreach (Student person in students)
            // {
            //     Console.WriteLine($"{person.firstName + " " + person.lastName} is working on:");
            //     Console.WriteLine("--------");
            //     foreach (Exercise assignment in person.exercises)
            //     {
            //         Console.WriteLine($"{assignment.name} in {assignment.language}");
            //         Console.WriteLine();
            //     }
            //     Console.WriteLine("^^^^^^^^^");
            // }

        }
    }
}
