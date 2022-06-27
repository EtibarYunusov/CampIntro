using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course courseOne = new Course();
            courseOne.CourseName = "C#";
            courseOne.CourseCoach = "Engin Demirog";
            courseOne.ViewInterest = 68;

            Course courseTwo = new Course();
            courseTwo.CourseName = "Java";
            courseTwo.CourseCoach = "Gencay Yildiz";
            courseTwo.ViewInterest = 58;

            Course courseThree = new Course();
            courseThree.CourseName = "SQL";
            courseThree.CourseCoach = "Ibrahim Oz";
            courseThree.ViewInterest = 85;

            List<Course> courses = new List<Course>();
            courses.Add(courseOne);
            courses.Add(courseTwo);
            courses.Add(courseThree);

            foreach (var course in courses)
            {
                Console.WriteLine("\n"+course.CourseName + " : " + course.CourseCoach + " : " + course.ViewInterest);
            }
        }
    }
    class Course
    {
        public string CourseName { get; set; }
        public string CourseCoach { get; set; }
        public int ViewInterest { get; set; }
    }
}
