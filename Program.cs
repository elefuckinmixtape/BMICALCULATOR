using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static BMICALCULATOR.inputHandler;
using static BMICALCULATOR.promptHandler;

namespace BMICALCULATOR
{
    internal class Program
    {
        private static class c_AllowedInputs
        {
            private static string[] YesNo = new string[] { "Yes", "No" };
        }
        static void Main(string[] args)
        {

            inputHandler inputHandler = new inputHandler();
            promptHandler promptHandler = new promptHandler();


            // Vars.
                // Input vars.
            string currentInput; // Current input.
            string[] allowedInputs; // If "currentInput" is a "string" then use this list of allowed inputs.
            
                // Confirmed vars.
            double d_Height; // Confirmed height.
            double d_Weight; // Confirmed weight.

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
