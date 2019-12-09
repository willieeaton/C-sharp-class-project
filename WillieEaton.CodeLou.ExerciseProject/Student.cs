using System;

namespace WillieEaton.CodeLou.ExerciseProject
{
    public class Student : IComparable<Student>
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
       public DateTimeOffset StartDate { get; set; }
        public string LastClassCompleted { get; set; }
        public DateTimeOffset LastClassCompletedOn { get; set; }

        public int CompareTo(Student that)
        {
            return this.StudentId.CompareTo(that.StudentId);
        }
    }
}