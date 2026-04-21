using System;
using System.Diagnostics;
using static BMICALCULATOR.inputHandler;

namespace BMICALCULATOR
{
    internal class Program
    {
        // Main method
        static void Main(string[] args)
        {
            // Vars
            double height;
            double weight;

            string currentInput;
            inputHandler inputHandler = new inputHandler();

            // Start of "Main"
            Console.WriteLine($"===== BMI Calculator ====="); Thread.Sleep(TimeSpan.FromSeconds(1.5));
            Console.WriteLine($"This program will calculate your Body Mass Index (BMI)"); Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine($"Please enter your height in meters, Ex: '1.75'");
            currentInput = inputHandler.GetInput($"string", );
            Console.WriteLine($"Perfect! Your height is {currentInput}? Please input 'Yes' or 'No'");

            Console.WriteLine($"Next, please enter your weight in kilograms, Ex: '70.5'");
            
            

        }
    }
}
