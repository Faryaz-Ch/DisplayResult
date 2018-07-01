using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Paractical1
{
    /// <summary>   
    ///  Program that asks from the user for a score or marks.
    ///  If the user input mark falls outside 0 – 100 display an error message.
    ///  Otherwise a grade is determined based on the following: 
    ///  0-50 (including 0 but not 50) = D 
    ///  50-70 (including 50 but not 70) = C 
    ///  70-80 (including 70 but not 80) = B 
    ///  80-100 (including both 80 and 100) = A 
    ///  Author: Faryaz
    /// </summary> 

    class MainClass
    {
        public static void Main(string[] args)
        {
            DisplayResults();

        }
        static void DisplayResults()
        {
            Write("Enter a mark (0-100): ");
            double mark = double.Parse(ReadLine());
            while (mark < 0 || mark > 100) //|| means or
            {
                Write("Invalid. Enter mark (0-100): ");
                mark = double.Parse(ReadLine());
            }

            if (mark >= 80)
                WriteLine("Grade A");
            else if ((mark >= 70) && (mark < 80))
                WriteLine("Grade B");
            else if ((mark >= 50) && (mark < 70))
                WriteLine("Grade C");
            else
                WriteLine("Grade D");


        }
    }
}