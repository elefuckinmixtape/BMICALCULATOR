using System;
using System.Reflection.Metadata.Ecma335;

namespace BMICALCULATOR
{
    public class inputHandler
    {
        private string[] _allowedInputs;

        private Type lastRequestedType;
        private string[] lastAllowedInputs;
        private bool isValid;
        private Type finalType;
        
        private void ValidateInput(string input, Type requestedType)
        {
            // Temp try variables
            double tryDouble;
            int tryInt;
           
            while (!string.IsNullOrEmpty(input)) // Check if "input" is not null or empty    
            {// "input" is not null or empty

                if (double.TryParse(input, out tryDouble) && requestedType == typeof(double))
                {// "input" is a "double" and "requestedType" == "double"
                    finalType = requestedType;
                    isValid = true; return;
                } 
                else if (requestedType == typeof(string) && _allowedInputs != null && _allowedInputs.Length > 0)
                {// "requestedType == "string"
                    finalType = requestedType;
                    foreach (string i in _allowedInputs)
                    {
                        if (!string.Equals(input, i, StringComparison.OrdinalIgnoreCase)) { continue; }   
                    }
                    if (string.Equals(input, "Yes", StringComparison.OrdinalIgnoreCase))
                    {
                        isValid = true; return;
                    }
                    else if (string.Equals(input, "No", StringComparison.OrdinalIgnoreCase))
                    {
                        isValid = true; return;
                    }
                    else
                    {

                    }
                }
                // "input" is a invalid
                isValid = false; return;
            } 
            // "input" is null or empty
            isValid = false; return;
            
        }

        public string GetInput(Type requestedType, string[] allowedInputs)
        {
            if (allowedInputs != null && allowedInputs.Length > 0) { _allowedInputs = allowedInputs; };
            string currentInput = Console.ReadLine();
            ValidateInput(currentInput, requestedType);
            while (!isValid)
            {
                Console.WriteLine($"INVALID INPUT! Please try again."); Thread.Sleep(TimeSpan.FromSeconds(.2));
                currentInput = Console.ReadLine();
                ValidateInput(currentInput, requestedType);
            }

            if (string.Equals(currentInput, "No", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"You have entered the input '{currentInput}', please enter the last requested input before confirmation.");
                requestedType = lastRequestedType; _allowedInputs = lastAllowedInputs;
                
            }
            
            lastRequestedType = requestedType; lastAllowedInputs = _allowedInputs;
            return currentInput;

        } 
    }
}