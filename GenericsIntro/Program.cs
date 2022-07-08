using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Etibar");
            myList.Add("Murad");
            myList.Add("Terxan");
            Console.WriteLine(myList.Count());
        }
    }
}
