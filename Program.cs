using System;

namespace UNIPROJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // making 5 Student objects and storing them in an array
            Student[] students = new Student[]
            {
                new Student("John McLane", 3.6, 12, "Junior", "Computer Information Systems", true),
                new Student("Sarah Connor", 3.8, 15, "Senior", "Engineering", true),
                new Student("Ellen Ripley", 3.2, 9, "Sophomore", "Biology", false),
                new Student("Tony Stark", 4.0, 18, "Senior", "Mechanical Engineering", true),
                new Student("Bruce Wayne", 2.8, 6, "Freshman", "Criminal Justice", false)
            };

            // show student original data
            Console.WriteLine("Initial Students:");
            DisplayStudents(students);

            // Make changes
            students[0].Name = "Jack McLane"; // Change name
            students[2].Enroll(); // Enroll student
            students[4].Unenroll(); // Unenroll student

            // Display all students data after changes
            Console.WriteLine("\nModified Students:");
            DisplayStudents(students);
        }

        // Method to display studentsdata
        public static void DisplayStudents(Student[] students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}