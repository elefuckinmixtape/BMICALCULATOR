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
            inputHandler inputHandler = new inputHandler();
            // Vars
            double heightD;
            double weightD;

            string currentInput;
            string[] allowedInputs = new string[] { "Yes", "No" }; // If currentInput is a "string"

            // Start of "Main"
            Console.WriteLine($"===== BMI Calculator ====="); Thread.Sleep(TimeSpan.FromSeconds(1.5));
            Console.WriteLine($"This program will calculate your Body Mass Index (BMI)"); Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine($"Please enter your height in meters, Ex: '1.75'");
            currentInput = inputHandler.GetInput(typeof(double), null);
            Console.WriteLine($"Great! so, the input {currentInput} is correct? Please input 'Yes or 'No'");
            currentInput = inputHandler.GetInput(typeof(string), allowedInputs);
            
            Console.WriteLine($"Perfect! Your height is {currentInput}? Please input 'Yes' or 'No'");

            Console.WriteLine($"Next, please enter your weight in kilograms, Ex: '70.5'");
            
            

        }
    }
}
