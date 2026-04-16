using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace BMICALCULATOR
{
    public class inputHandler
    {
        string[] allowedInputs;
        bool isValid;
        private void ValidateInput(string input)
        {
            // Temp try variables
            double tryDouble;
            int tryInt;

            while (!string.IsNullOrEmpty(input)) // Check if "input" is not null or empty
                // "input" is not null or empty
            {
                if (double.TryParse(input, out tryDouble))
                    // "input" is a "double"
                {

                    return;
                }
                // "input" is a "string"
                isValid = true;
                return;
            } 
            // "input" is null or empty
            isValid = false;
            
        }

        public string GetInput(params string[] allowedInput)
        {
            if (allowedInput != null) 
            {
                int totalAllowedInputs = 0;

                foreach (string i in allowedInput)
                {
                    totalAllowedInputs++;
                    allowedInputs = new string[] { i };
                    Console.WriteLine(allowedInputs[]);
                }
            }
            string currentInput = Console.ReadLine();
            ValidateInput(currentInput);
            while (!isValid)
            {
                Console.WriteLine($"INVALID INPUT! Please try again."); Thread.Sleep(TimeSpan.FromSeconds(.2));
                currentInput = Console.ReadLine();
                ValidateInput(currentInput);
            }
            return currentInput;

        } 
    }
}