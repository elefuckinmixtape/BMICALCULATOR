using System;
using System.Threading;
using System.Runtime.CompilerServices;

using static BMICALCULATOR.Program;

namespace BMICALCULATOR
{
    internal class Program
    {
        // TempVars
        private string currentInput;

        private double D_Height;
        private double D_Weight;

        static void PRINT(string toPrint, float delay)
        {
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
        static void Main(string[] args)
        {
            // Start :>
            PRINT($"MEWO", 1);
        }
    }
}
