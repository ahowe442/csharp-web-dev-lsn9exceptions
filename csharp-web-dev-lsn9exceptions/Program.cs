using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {

            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Value is 0");
            }
            return x / y;
         
        }

        //static int CheckFileExtension(string fileName)
        //{
        //    // Write your code here!
        //}


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            try
            {
                Console.WriteLine(Divide(80, 0));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Y can not be equal to zero");
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


        }
    }
}
