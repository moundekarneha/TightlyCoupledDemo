using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TightlyCoupledDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Standard { get; set; }
    }

    public class StudentDataAccessLayer
    {
      public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student()
            {
                Id = 1,
                Name = "Neha",
                Standard = "A"
            });

            students.Add(new Student()
            {
                Id = 2,
                Name = "Sneha",
                Standard = "A"
            });

            students.Add(new Student()
            {
                Id = 3,
                Name = "Nehal",
                Standard = "A"
            });

            students.Add(new Student()
            {
                Id = 4,
                Name = "Himanshu",
                Standard = "B"
            });

            students.Add(new Student()
            {
                Id = 5,
                Name = "Kunal",
                Standard = "A"
            });
            return students;
        }
        
    }


    //below class is highly dependent on StudentDataAccessLayer --Tightly coupled example
    public class StudentBussinessLayer
    {
        public List<Student> GetStudents()
        {
            StudentDataAccessLayer obj = new StudentDataAccessLayer();
            return obj.GetStudents();
        }
    }
}
