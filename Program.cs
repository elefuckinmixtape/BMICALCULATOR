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
        public static double doubleHeight;
        public static double doubleWeight;
    }
    internal class Program
    {
        static void GetInput()
        {
            static void ValidateInput(string input)
            {
                 
            }
            string tempInput = Console.ReadLine();

        }
        static void Print(int delay, string output)
        {
            Thread.Sleep(TimeSpan.FromSeconds(delay));
            if (!output.Contains("Loading", StringComparison.OrdinalIgnoreCase))
            { // output not Loading
                Console.WriteLine($"> {output}");
            } else 
            { // output = "Loading"
                Console.WriteLine($" > {output}"); 
            };
        }
        // Main method
        static void Main(string[] args)
        {
            static void FakeLoad()
            {
                int loadTicks = 9; // Amount of times it will do a load cycle (every 4 is a full animated cycle)
                int currentDotTicks = 0; // Amount of current "." on loading text
                string currentText = $"Loading"; // Current text to display
                Print(0, $"{currentText}");
                for (int i = 0; i < loadTicks; i++)
                {
                    if (currentDotTicks < 4)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        currentText = $"{currentText}.";
                        Print(0, $"{currentText}");
                        currentDotTicks++;
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                    }
                    else
                    {
                        Console.SetCursorPosition(13, Console.CursorTop - 1); Console.WriteLine($"\b\b\b\b     ");
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        currentText = $"Loading";
                        Print(0, $"{currentText}");

                        currentDotTicks = 0;
                    }
                }
                Print(1, $"LOADING COMPLETE!");
            }
            
            // Start of "Main"
            Print(0, $"BMI CALCULATOR INITIALIZING..{Environment.NewLine}>       PLEASE WAIT...");
            Thread.Sleep(TimeSpan.FromSeconds(.5)); FakeLoad();
            // Continue "Main" method
            Print(2, $"Welcome to the BMI Calculator!");
            Print(1, $"This program will calculate your average BMI.");
            Print(1, $"To start off, please input your height in meters..");
            
            

           

        }
    }
}
