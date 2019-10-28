using System;

namespace WillieEaton.CodeLou.ExerciseProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Student Registry.  Let\'s create a");
            Console.WriteLine("new student record!");

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

            var newStudent = new Student();
            newStudent.StudentId = studentId;
            newStudent.FirstName = firstName;
            newStudent.LastName = lastName;
            newStudent.ClassName = className;
            newStudent.StartDate = startDate;
            newStudent.LastClassCompleted = lastClassCompleted;
            newStudent.LastClassCompletedOn = lastClassCompletedOn;

        }
    }
}
