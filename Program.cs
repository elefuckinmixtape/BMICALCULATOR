using System;
using System.Threading;
using System.Runtime.CompilerServices;

using static BMICALCULATOR.Program;

namespace BMICALCULATOR
{
    internal class Program
    {
        // TempVars
        static string currentInput;

        static double D_Height;
        static double D_Weight;

        static void PRINT(string toPrint, float delay)
        {
            // TempVars
            string P_PrintMessage;
            float P_Delay;

            if (!string.IsNullOrEmpty(toPrint))
            {
                P_PrintMessage = toPrint;
                if (delay !< 0f)
                {
                    P_Delay = delay;
                }
                else
                {
                    P_Delay = 0f;
                }
                Thread.Sleep(TimeSpan.FromSeconds(P_Delay));
                Console.WriteLine(P_PrintMessage);
            }
            else
            {
                Console.WriteLine($"ERROR PRINT MESSAGE IS INVALID! Please breathe deeply from the toilet bowl.");
            }
        }
        static bool VALIDATE_INPUT(string input) 
        {
            // TempVars
            double D_TryParse;

            if (double.TryParse(input, out D_TryParse))
            {
                // "R_Input" is a double
                return true;

            }
            else if (!string.IsNullOrEmpty(input))
            {
                return true;
            }
            return false;
        }
        static string REG_INPUT()
        {
            // TempVars
            string R_Input;
            bool IsValid;

            R_Input = Console.ReadLine();
            IsValid = VALIDATE_INPUT(R_Input);
            if (!IsValid) { return null; }
            return R_Input;

        }
        
        string GETINPUT()
        {
            // TempVars
            string tmp_currentInput;

            double D_TryParse;

            tmp_currentInput = Console.ReadLine();
            if (double.TryParse(tmp_currentInput, out D_TryParse))
            {

            }
            else if (!string.IsNullOrEmpty(tmp_currentInput))
            {

            }
        }
        static void Main(string[] args)
        {
            double F_TotalBMI;

            // Start :>
            PRINT($"===== BMI Calculator =====", 0f);
            PRINT($"This program will calculate your Body Mass Index (BMI)!", 3f);
            Console.WriteLine();
            PRINT($"Please enter your 'height' in meters: EX 1.75 ", 1f);
            D_Height = double.Parse(REG_INPUT());
            Console.WriteLine();
            PRINT($"Perfect!", 1f);
            PRINT($"Now, please enter your 'weight' in kilograms: EX 70.5", 3f);
            D_Weight = double.Parse(REG_INPUT());
            Console.WriteLine();
            PRINT($"Perfect! The height you entered is ({D_Height}) in meters and the weight you entered is ({D_Weight}) in kilograms.", 3f);
            PRINT($"Please wait a moment while your 'BMI' is being calculated.", 1f);
            F_TotalBMI = D_Weight / Math.Pow(D_Height, 2f);
            PRINT($"Your total 'BMI' is : {F_TotalBMI}", 2f);

        }
    }
}
