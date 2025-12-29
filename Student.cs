using System;

namespace UNIPROJ
{
    public class Student
    {
        // Constants for default values
        public const double DEFAULT_GPA = 4.0;
        public const int DEFAULT_CREDITS = 12;

        // Private fields initialized thru constructor
        private string _name;
        private double _gpa;
        private int _creditHours;
        private string _classification;
        private string _major;
        private bool _enrollmentStatus;

        // Constructor with specific public requirements
        public Student(string name, double gpa, int creditHours, string classification, string major, bool enrollmentStatus)
        {
            Name = name;
            GPA = gpa;
            CreditHours = creditHours;
            Classification = classification;
            Major = major;
            _enrollmentStatus = enrollmentStatus;
        }

        // Property for Name
        public string Name { get; set; }

        // Property for GPA with validation
        public double GPA
        {
            get { return _gpa; }
            set { _gpa = (value >= 0.0 && value <= 4.0) ? value : DEFAULT_GPA; }
        }

        // Property for Credit Hours with validation
        public int CreditHours
        {
            get { return _creditHours; }
            set { _creditHours = (value >= 0 && value <= 18) ? value : DEFAULT_CREDITS; }
        }

        // Property for Classification
        public string Classification { get; set; }

        // Property for Major
        public string Major { get; set; }

        // Method to enroll the student
        public void Enroll() => _enrollmentStatus = true;

        // Method to unenroll the student
        public void Unenroll() => _enrollmentStatus = false;

        // Method to check enrollment status
        public bool IsEnrolled() => _enrollmentStatus;

        // Override ToString method to format student data
        public override string ToString()
        {
            return $"Name: {Name}{Environment.NewLine}" +
                   $"GPA: {GPA:F1}{Environment.NewLine}" +
                   $"Credit Hours: {CreditHours}{Environment.NewLine}" +
                   $"Classification: {Classification}{Environment.NewLine}" +
                   $"Major: {Major}{Environment.NewLine}" +
                   $"Enrolled: {IsEnrolled()}{Environment.NewLine}";
        }
    }
}