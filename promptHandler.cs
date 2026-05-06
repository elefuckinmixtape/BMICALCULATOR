using System;
using System.Runtime.CompilerServices;

// GOAL :
// Validate and print given "inputs" with optional delay.
// WILL NOT :
// Do anything more than print and validate given inputs with a optional delay.
// WHY? :
// To hopefully have a way to go back on prompts without a bunch of if statements :>.

namespace BMICALCULATOR
{
    public class promptHandler
    {
        // Fields
        private string currentPrompt;
        private float currentDelayTime;

        // Chudoids
        public string _currentPrompt { get { return currentPrompt; } set { if (!string.IsNullOrEmpty(currentPrompt)) { _currentPrompt = value; } } }

        public void ProcessData(string promptData, float delayTime)
        {
            if (string.IsNullOrEmpty(promptData)) { return; }
            // "promptData" is not null or empty
            currentPrompt = promptData;
        }
    }
}
