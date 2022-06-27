using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            FourCalculate calculate = new();
            calculate.Sum(10, 98);
            calculate.Sum(-5, 8);
        }
    }
}
