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
            if (!output.Contains("Loading"))
            { // output not Loading
                Console.WriteLine($"> {output}");
            } else 
            { // output = "Loading"
                Console.WriteLine($" > {output}"); 
            };
        }
        public static async void Wait(double waitTime)
        {
            var task = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(waitTime));
            }); task.Wait();
        }
        public static void FakeLoad()
        {
            int loadTicks = 9; // Amount of times it will do a load cycle (every 4 is a full animated cycle)
            int currentDotTicks = 0; // Amount of current "." on loading text
            string currentText = $"Loading";
            Print($"{currentText}");
            for (int i = 0; i < loadTicks; i++)
            {
               if (currentDotTicks < 4)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Print($"{currentText}");
                    currentText = $"{currentText}.";
                    currentDotTicks++;
                    Wait(1);
                } else
                {
                    Console.SetCursorPosition(13, Console.CursorTop - 1); Console.WriteLine($"\b\b\b\b     ");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    currentText = $"Loading";
                    Print($"{currentText}");
                    
                    currentDotTicks = 0;
                }
            }
            Wait(1);
            Print($"LOADING COMPLETE!");

        }
        public static void Main(string[] args)
        {
            // Start of "Main"
            Print($"BMI CALCULATOR INITIALIZING..{Environment.NewLine}>       PLEASE WAIT...");
            //await Task.Delay(TimeSpan.FromSeconds(2)); FakeLoad();
            Wait(.5); FakeLoad();


        }
    }
}
