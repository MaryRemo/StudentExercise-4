using StudentExercise;
using StudentExercise.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();

            List<Exercise> exercises = repository.GetAllExercises();

            // PrintDepartmentReport should print a department report to the console, but does it?
            //  Take a look at how it's defined below...
            PrintExerciseReport("All Exercises", exercises);

            // What is this? Scroll to the bottom of the file and find out for yourself.
            Console.ReadKey();

            PrintJavascriptExercises("Javascript", exercises);

            Console.ReadKey();

            Exercise stevesgithubthing = new Exercise
            {
                Name = "stevesgithubthing",
                Language = "Javscript"
            };
            // Pass the accounting object as an argument to the repository's AddDepartment() method.
            repository.AddExercise(stevesgithubthing);

            exercises = repository.GetAllExercises();
            PrintExerciseReport("All Exercises after adding Stevesthing exercise", exercises);

            Console.ReadKey();

            List<Instructor> instructors = repository.GetAllInstructors();

            PrintInstructorReport("All Instructors", instructors);

            Console.ReadKey();
        }

        public static void PrintExerciseReport(string title, List<Exercise> exercises)
        {

            Console.WriteLine("All Exercises");
            foreach (Exercise exer in exercises)
            {
                Console.WriteLine($"{exer.Id}:{exer.Name},{exer.Language}");
            }
        }

        public static void PrintInstructorReport(string title, List<Instructor> instructors)
        {

            Console.WriteLine("All Instructors");
            foreach (Instructor instr in instructors)
            {
                Console.WriteLine($"{instr.Id}:{instr.FirstName},{instr.LastName}, {instr.SlackHandle}, {instr.cohorts.Name}");
            }
        }


        public static void PrintJavascriptExercises(string title, List<Exercise> exercises)
        {

            Console.WriteLine("Javascript Exercises");
            foreach (Exercise exer in exercises) {
                if (exer.Language == "Javascript")
                {
                Console.WriteLine($"{exer.Id}:{exer.Name},{exer.Language}");
                }
            
            }
        }

    }
}
