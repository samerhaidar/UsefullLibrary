using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions
{
    public class TestProgram
    {
        static void Main(string[] args)
        {
            var age = new DateTime(1990, 09, 23).CalculateAge();
      
            Console.WriteLine(age);
        }
    }
}
