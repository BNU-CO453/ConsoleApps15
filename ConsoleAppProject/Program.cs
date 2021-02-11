using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 14/12/2020
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();

            // Using an extension method for each enumeration
            Console.WriteLine("Using MyEnum Extension Method!\n");
            Console.WriteLine("MyEnum Value = " + MyEnum.FirstValue);
            Console.WriteLine("MyEnum Friendly Value = " + MyEnum.FirstValue.EnumValue());
            Console.WriteLine();

            // Using an extension method for any enumeration
            StudentGrades grades = new StudentGrades();
            grades.TestGradesEnumeration();
        }
    }
}
