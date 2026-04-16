using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace BMICALCULATOR
{
    public class inputHandler
    {
        bool isValid;
        private void ValidateInput(string input)
        {
            double tryDouble;
            int tryInt;
            
            if (!string.IsNullOrEmpty(input)) // Check if "input" has is not empty
            {
                isValid = true;
                
                return;
            } 
            isValid = false;
            
        }

        public string GetInput()
        {
            string currentInput = Console.ReadLine();
            ValidateInput(currentInput);
            while (!isValid)
            {
                Console.WriteLine($"INVALID INPUT! Please try again."); Thread.Sleep(TimeSpan.FromSeconds(.4));
                currentInput = Console.ReadLine();
                ValidateInput(currentInput);
            }
            return currentInput;

        } 
    }
}