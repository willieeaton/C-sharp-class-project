using System;
using System.Collections.Generic;

namespace WillieEaton.CodeLou.ExerciseProject
{
    class Program
    {
        static void Main()
        {
            var finished = false;
            var students = new List<Student>();

            Console.WriteLine("Welcome to the Student Registry.  Let\'s create a new student record!");

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Enter the Student ID number.");
                var studentId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the student\'s given name.");
                var firstName = Console.ReadLine();
                Console.WriteLine("Enter the student\'s family name.");
                var lastName = Console.ReadLine();
                Console.WriteLine("Enter the current class in which the student is enrolled.");
                var className = Console.ReadLine();
                Console.WriteLine("Enter the class start date.");
                var startDate = DateTimeOffset.Parse(Console.ReadLine());
                Console.WriteLine("Enter the last course the student completed.");
                var lastClassCompleted = Console.ReadLine();
                Console.WriteLine("Enter the date that course was completed.");
                var lastClassCompletedOn = DateTimeOffset.Parse(Console.ReadLine());

                var newStudent = new Student
                {
                    StudentId = studentId,
                    FirstName = firstName,
                    LastName = lastName,
                    ClassName = className,
                    StartDate = startDate,
                    LastClassCompleted = lastClassCompleted,
                    LastClassCompletedOn = lastClassCompletedOn
                };
                students.Add(newStudent);

                Console.WriteLine("");
                Console.WriteLine("Add another student record?");
                var response = Console.ReadLine().ToUpper();
                if (response == "N" || response == "NO")
                    finished = true;

            } while (!finished);

            foreach(var student in students)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Student ID: {student.StudentId}");
                    Console.WriteLine($"Student name: {student.FirstName} {student.LastName}");
                    Console.WriteLine($"Current class: {student.ClassName} started {student.StartDate}");
                    Console.WriteLine($"Previous class: {student.LastClassCompleted} finished {student.LastClassCompletedOn}");
                }
        }
    }
} 
