using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result = new Calculator().AddNumbers(10, 20);// test comment
            Console.ReadLine();
        }

       
    }


    public class Calculator
    {
        public int AddNumbers(int a, int b) // Add comment
        {
            return (a + b);

        }
    }

}
