using System;

namespace BMICALCULATOR
{
    public class inputHandler
    {
        private string[] _allowedInputs;
        bool isValid;
        string finalType;
        string currentErrorMessage;
        private void ValidateInput(string input, string requestedType)
        {
            // Temp try variables
            double tryDouble;
            int tryInt;
            
            while (!string.IsNullOrEmpty(input)) // Check if "input" is not null or empty    
            {// "input" is not null or empty

                if (double.TryParse(input, out tryDouble) && requestedType == "double")
                {// "input" is a "double" and "requestedType" == "double"
                    finalType = requestedType;
                    isValid = true;
                    return;
                } 
                else if (requestedType == "string" && _allowedInputs != null && _allowedInputs.Length > 0)
                {// "requestedType == "string"
                    finalType = requestedType;
                    foreach (string i in _allowedInputs)
                    {
                        Console.WriteLine(i);
                    }
                }
                // "input" is a invalid
                isValid = false;
                return;
            } 
            // "input" is null or empty
            isValid = false;
            
        }

        public string GetInput(string requestedType, string[] allowedInputs)
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
            return currentInput;

        } 
    }
}