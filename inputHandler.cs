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
                    isValid = true;
                    return;
                } 
                if (int.TryParse(input, out tryInt))
                    // "input" is a "int"
                {
                    isValid = true;
                    return;
                }
                // "input" is a "string"
                
                return;
            } 
            // "input" is null or empty
            isValid = false;
            
        }

        public string GetInput()
        {
            
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