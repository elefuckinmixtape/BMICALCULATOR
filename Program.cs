using System;
using System.Threading;
using System.Threading.Tasks;

namespace BMICALCULATOR
{
    public class Variables
    // Variables class/storage
    {
        public double doubleHeight;
        public double doubleWeight;

    }
    internal class Program
    {
        public static void Print(string output)
        {
            if (!string.Contains(output, $"Loading", StringComparison.OrdinalIgnoreCase))
            { // output not Loading
                Console.WriteLine($"> {output}");
            } else 
            { // output = "Loading"
                Console.WriteLine($" > {output}"); 
            };
        }
        // Fake loading system
        public static void FakeLoad()
        {
            int loadTicks = 9; // Amount of times it will do a load cycle (every 4 is a full animated cycle)
            int currentDotTicks = 0; // Amount of current "." on loading text
            string currentText = $"Loading"; // Current text to display
            Print($"{currentText}");
            for (int i = 0; i < loadTicks; i++)
            {
               if (currentDotTicks < 4)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Print($"{currentText}");
                    currentText = $"{currentText}.";
                    currentDotTicks++;
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                } else
                {
                    Console.SetCursorPosition(13, Console.CursorTop - 1); Console.WriteLine($"\b\b\b\b     ");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    currentText = $"Loading";
                    Print($"{currentText}");
                    
                    currentDotTicks = 0;
                }
            }
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Print($"LOADING COMPLETE!");
        }
        // "Main method
        public static void Main(string[] args)
        {
            // Start of "Main"
            Print($"BMI CALCULATOR INITIALIZING..{Environment.NewLine}>       PLEASE WAIT...");
            Thread.Sleep(TimeSpan.FromSeconds(.5)); FakeLoad();
            // Continue "Main" method
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Print($"Welcome to the BMI Calculator!");

        }
    }
}
