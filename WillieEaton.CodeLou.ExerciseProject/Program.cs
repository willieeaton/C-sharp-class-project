using System;
using System.Collections.Generic;

namespace WillieEaton.CodeLou.ExerciseProject
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static Dictionary<string, Student> studentDict = new Dictionary<string, Student>();

        static void Main()
        {
            bool keepLooping = true;
            Console.WriteLine("Welcome to the student directory.");
            AddStudents();
            do
            {
                Console.WriteLine("Welcome to the student directory.  Please choose an option.");
                Console.WriteLine("1. Add students");
                Console.WriteLine("2. List students");
                Console.WriteLine("3. Search for student by name");
                Console.WriteLine("4. Exit directory");
                int menuChoice = 0;
                int.TryParse(Console.ReadLine(), out menuChoice);
                if (menuChoice >= 1 && menuChoice <= 4)
                {
                    switch (menuChoice)
                    {
                        case 1: 
                            AddStudents();
                            break;

                        case 2:
                            ListStudents();
                            break;

                        case 3:
                            SearchStudents();
                            break;

                        case 4:
                            keepLooping = false;
                            break;
                    }


                }
            } while (keepLooping);

        }

        static void AddStudents()
        {

            Console.WriteLine("Creating a new student record.");
            var finished = false;
            do
            {
                Console.WriteLine("");
                bool validated = false;
                int studentId;
                do
                {
                    Console.WriteLine("Enter the Student ID number.");
                    validated = int.TryParse(Console.ReadLine(), out studentId);
                } while (!validated);
                Console.WriteLine("Enter the student\'s first (given) name.");
                var firstName = Console.ReadLine();
                Console.WriteLine("Enter the student\'s last (family) name.");
                var lastName = Console.ReadLine();
                Console.WriteLine("Enter the current class in which the student is enrolled.");
                var className = Console.ReadLine();
                validated = false;
                DateTimeOffset startDate;
                do
                {
                    Console.WriteLine("Enter the class start date.");
                    validated = DateTimeOffset.TryParse(Console.ReadLine(), out startDate);
                } while (!validated);
                Console.WriteLine("Enter the last course the student completed.");
                var lastClassCompleted = Console.ReadLine();
                validated = false;
                DateTimeOffset lastCourseCompletedOn;
                do
                {
                    Console.WriteLine("Enter the date that course was completed.");
                    validated = DateTimeOffset.TryParse(Console.ReadLine(), out lastCourseCompletedOn);
                } while (!validated);

                var newStudent = new Student
                {
                    StudentId = studentId,
                    FirstName = firstName,
                    LastName = lastName,
                    ClassName = className,
                    StartDate = startDate,
                    LastClassCompleted = lastClassCompleted,
                    LastClassCompletedOn = lastCourseCompletedOn
                };
                students.Add(newStudent);
                studentDict.Add(newStudent.FirstName + " " + newStudent.LastName, newStudent);

                Console.WriteLine("");
                Console.WriteLine("Add another student record?");
                var response = Console.ReadLine().ToUpper();
                if (response == "N" || response == "NO")
                {
                    finished = true;
                }
            } while (!finished);
        }

        static void ListStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine("");
                Console.WriteLine($"Student ID: {student.StudentId}");
                Console.WriteLine($"Student name: {student.FirstName} {student.LastName}");
                Console.WriteLine($"Current class: {student.ClassName} started {student.StartDate}");
                Console.WriteLine($"Previous class: {student.LastClassCompleted} finished {student.LastClassCompletedOn}");
                Console.WriteLine("");
            }
        }

        static void ListStudents(Student student)
        {
            Console.WriteLine("");
            Console.WriteLine($"Student ID: {student.StudentId}");
            Console.WriteLine($"Student name: {student.FirstName} {student.LastName}");
            Console.WriteLine($"Current class: {student.ClassName} started {student.StartDate}");
            Console.WriteLine($"Previous class: {student.LastClassCompleted} finished {student.LastClassCompletedOn}");
            Console.WriteLine("");
        }

        static void SearchStudents()
        {
            Console.WriteLine("Please enter a student's full name.");
            var searchName = Console.ReadLine();

            if(studentDict.TryGetValue(searchName, out Student student))
            {
                ListStudents(student); 
            }
            else
            {
                Console.WriteLine($"{searchName} not found in database.");
                Console.WriteLine("Please check spelling and capitalization.");
            }
        }
    }
} 
