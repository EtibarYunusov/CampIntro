using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string courseOne = "Yazilim Gelishtirici Yetishtirme Kampi";
            string courseTwo = "Programlamaya bashlangic kursu";
            string courseThree = "Java";
            string courseFour = "Python";

            //array - dizi

            string[] courses = new string[] 
            { 
              "Yazilim Gelishtirici Yetishtirme Kampi", 
              "Programlamaya bashlangic kursu", 
              "Java",
              "Python"
            };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("\nFooter");
        }
    }
}
