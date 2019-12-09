using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WillieEaton.CodeLou.ExerciseProject
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static Dictionary<string, Student> studentDict = new Dictionary<string, Student>();

        static void Main()
        {
            bool keepLooping = true;

            LoadStudents();

            do
            {
                Console.WriteLine("Welcome to the student directory.  Please choose an option.");
                Console.WriteLine("1. Add students");
                Console.WriteLine("2. List students");
                Console.WriteLine("3. Search for student by name");
                Console.WriteLine("4. Search for student by current class");
                Console.WriteLine("5. Exit directory");
                int menuChoice = 0;
                int.TryParse(Console.ReadLine(), out menuChoice);
                if (menuChoice >= 1 && menuChoice <= 5)
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
                            SearchByClass();
                            break;

                        case 5:
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
                    if (validated)
                    {
                        if(students.Exists( s => s.StudentId == studentId ))
                        {
                            Console.WriteLine("Student already exists in registry with this ID number.");
                            validated = false;
                        }
                    }
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
                    if(validated)
                    {
                        if (lastCourseCompletedOn >= startDate)
                        {
                            Console.WriteLine("Course must have been completed prior to current course start date.");
                            validated = false;
                        }
                    }
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

            //once all students have been entered
            students.Sort();
            SaveStudents();
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

        static void ListStudents(IEnumerable<Student> selectedStudents)
        {
            foreach (Student student in selectedStudents)
            {
                ListStudents(student);
            }
        }

        static void SearchStudents()
        {
            Console.WriteLine("Please enter a student's first or last name.");
            var searchName = Console.ReadLine();
            var selectedStudents = students.Where(s => s.FirstName.IndexOf(searchName, StringComparison.CurrentCultureIgnoreCase) >= 0 || s.LastName.IndexOf(searchName, StringComparison.CurrentCultureIgnoreCase) >= 0);
            if (selectedStudents.Any())
            {
                ListStudents(selectedStudents);
            }
            else
            {
                Console.WriteLine($"{searchName} not found in database.");
                Console.WriteLine("Please check spelling.");
            }
        }

        private static void SearchByClass()
        {
            Console.WriteLine("Please enter a class to search for.");
            var searchName = Console.ReadLine();
            var selectedStudents = students.Where(s => s.ClassName.IndexOf(searchName, StringComparison.CurrentCultureIgnoreCase) >= 0);
            if (selectedStudents.Any())
            {
                ListStudents(selectedStudents);
            }
            else
            {
                Console.WriteLine($"{searchName} not found in database.");
                Console.WriteLine("Please check spelling.");
            }
        }


        static void SaveStudents()
        {
            var serializer = new JsonSerializer();
            string fileName = "Students.JSON";
            using (var writer = new StreamWriter(fileName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, students);
            }

        }

        static void LoadStudents()
        {
            string fileName = "Students.JSON";
            if (File.Exists(fileName))
            {
                var serializer = new JsonSerializer();
                using (var reader = new StreamReader(fileName))
                using (var jsonReader = new JsonTextReader(reader))
                {
                    students = serializer.Deserialize<List<Student>>(jsonReader);
                }
            }
            else
            {
                Console.WriteLine("Students database not found on disk.  Will be created upon adding students.");
            }
        }
    }
}
