using System;

namespace WillieEaton.CodeLou.ExerciseProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Student Registry.  Let\'s create a");
            Console.WriteLine("new student record!");

            bool finishedFlag = false;

            do
            {

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

                Console.WriteLine("");
                Console.WriteLine($"Student ID: {newStudent.StudentId}");
                Console.WriteLine($"Student name: {newStudent.FirstName} {newStudent.LastName}");
                Console.WriteLine($"Current class: {newStudent.ClassName} started {newStudent.StartDate}");
                Console.WriteLine($"Previous class: {newStudent.LastClassCompleted} finished {newStudent.LastClassCompletedOn}");
                Console.WriteLine("");
                Console.WriteLine("Add another student record?");
                string response = Console.ReadLine().ToUpper();
                if (response == "N" || response == "NO")
                    finishedFlag = true;
            } while (finishedFlag == false);
        }
    }
}
