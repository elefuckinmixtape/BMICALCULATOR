using System;
using System.ComponentModel.Design;
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

        // Properties
        public string _currentPrompt 
        { get { return currentPrompt; } 
            set 
            { 
                if (!string.IsNullOrEmpty(value)) 
                { 
                    _currentPrompt = value; 
                }
            } 
        }
        public float _currentDelayTime 
        { get { return currentDelayTime; } 
            set 
            { if (value.ToString() != null) 
                { 
                    currentDelayTime = value; 
                } else 
                { currentDelayTime = 0f; 
                }
            } 
        }

    }
}
