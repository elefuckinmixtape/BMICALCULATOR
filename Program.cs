using System;
using System.ComponentModel.Design;
using System.Threading;
using System.Threading.Tasks;
using static BMICALCULATOR.Variables;

namespace BMICALCULATOR
{
    public static class Variables
    // Variables class/storage
    {
        public static string currentInput; 
        public static double doubleHeight; // Height value
        public static double doubleWeight; // Weight value
    }
    internal class Program
    {
        static void GetInput(Type inputType, List<string> allowedInputs)
        {
            static void ValidateInput(string input, Type inputType, List<string> allowedInputs)
            {
                object temp = Convert.ChangeType(input, inputType);
                if ()
                
            }
            string tempInput = Console.ReadLine(); // Get input
            
        }
        // Main method
        static void Main(string[] args)
        {
            // Start of "Main"
            GetInput(typeof(double), null); // Get "height" in meters
            
            

           

        }
    }
}
