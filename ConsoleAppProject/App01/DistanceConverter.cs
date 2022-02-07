using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;
        private double feet;
        private string number;

        /// <summary>
        /// This method will output a heading, ask dfor the
        /// input for miles, calculate and output the same
        /// distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private static void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" ========================");
            Console.WriteLine("    Distance Converter   ");
            Console.WriteLine("        by Derek         ");
            Console.WriteLine(" ========================");
            Console.WriteLine();
        }

        private void OutputFeet()
        {
            Console.WriteLine("The number of miles = " + feet);
        }

        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void InputMiles()
        {
            Console.Write(" Please input the distance in miles > ");
            
            number = Console.ReadLine();
            miles = Convert.ToDouble(number);
        }
    }
}
