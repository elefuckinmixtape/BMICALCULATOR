using System;

namespace BMICALCULATOR
{
    public class inputHandler
    {
        string currentInput;
        bool isValid;
        private Type GetType(string input)
        {
            
        }
        private bool ValidateInput(string input)
        {
            int tryInt;
            double tryDouble;
            if (!string.IsNullOrEmpty(input))
            { 
                
                return true;
               
            }
            else
            {
                
                return false;
            }
        }

        public string GetInput()
        {
            currentInput = Console.ReadLine();
            isValid = ValidateInput(currentInput);
            return currentInput;
        }

        
    }
}