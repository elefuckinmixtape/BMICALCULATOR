using System;
using System.Runtime.CompilerServices;

namespace BMICALCULATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vars
            string currentInput;

            double D_Height;
            double D_Weight;
            double F_TotalBMI;

            // Start :>
            Console.WriteLine($"===== BMI Calculator =====");
            Console.WriteLine($"This program will calculate your Body Mass Index (BMI)!");
            Console.WriteLine();
            Console.WriteLine($"Please enter your 'height' in meters: EX 1.75");
            Console.WriteLine();
            currentInput = Console.ReadLine();
            Console.WriteLine();
            D_Height = double.Parse(currentInput);
            Console.WriteLine($"Perfect!");
            Console.WriteLine($"Now, please enter your 'weight' in kilograms: EX 70.5");
            Console.WriteLine();
            currentInput = Console.ReadLine();
            Console.WriteLine();
            D_Weight = double.Parse(currentInput);
            Console.WriteLine($"Perfect! The height you entered is ({D_Height}) in meters and the weight you entered is ({D_Weight}) in kilograms.");
            Console.WriteLine($"Please wait a moment while your 'BMI' is being calculated!");
            F_TotalBMI = D_Weight / Math.Pow(D_Height, 2f);
            Console.WriteLine($"Your total 'BMI' is : {F_TotalBMI}");
            Console.WriteLine();
            Console.WriteLine($"Program is now closing.");
        }
    }
}
