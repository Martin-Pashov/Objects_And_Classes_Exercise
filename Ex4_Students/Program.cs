using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex4_Students
{
    class Student
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public double grade { get; set; }


        public Student(string firstName, string secondName, double grade)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.grade = grade;
        }


        public double getGrade()
        {
            return this.grade;
        }


        public override string ToString()
        {
            return string.Format(this.firstName, this.secondName, this.grade);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                string firstName = info[0];
                string secondName = info[1];
                double grade = double.Parse(info[2]);

                Student student = new Student(firstName, secondName, grade);
                students.Add(student);
            }


            students.OrderByDescending(t => t.grade).ThenBy(t => t.firstName).ToList();
            List<Student> sortedStudents = students.OrderByDescending(t => t.grade).ThenBy(t => t.firstName).ThenBy(t => t.secondName).ToList();


            foreach (Student t in sortedStudents)
            {

                Console.WriteLine($"{t.firstName} {t.secondName}: {t.grade:f2}");
            }
        }
    }
}