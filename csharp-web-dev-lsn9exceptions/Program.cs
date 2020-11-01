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

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            int StudentCSharpScore= 0;
            //string FileName = fileName; 
            string Substr = fileName.Substring(fileName.Length - 3);

            if (Substr == ".cs")
            {

                StudentCSharpScore = +1;
                Console.WriteLine(fileName + " Substring is: " + Substr + "file type  score is: " + StudentCSharpScore );
                return StudentCSharpScore;
            }
            else if(Substr == "" || Substr.Equals(null))
       
            StudentCSharpScore = +0;
            Console.WriteLine(fileName + " Substring is: " + Substr + "file type  score is: " + StudentCSharpScore);
            throw new ArgumentNullException("Must submit a file with a .cs filetype.");
            return StudentCSharpScore;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            try
            {
                Console.WriteLine(Divide(80, 100));
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

            foreach (var (key, value) in students)
            {
                try
                {
                    Console.WriteLine($"{key} : {value}");
                    string fileName = value;
                    CheckFileExtension(fileName);
                }
                catch
                {
                    Console.WriteLine($"{key} : File is not a C# type or is empty. \n Score is 0");
                }
                
            }


        }
    }
}
