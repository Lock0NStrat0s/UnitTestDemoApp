using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Red, Green, Refactor

namespace DemoLibrary
{
    public class DisplayMessages
    {
        public string Greeting(string firstName, int hourOfTheDay)
        {
            string output = "";

            if (hourOfTheDay < 5)
            {
                output = $"Go to bed {firstName}";
            }
            else if (hourOfTheDay < 12)
            {
                output = $"Good Morning {firstName}";
            }
            else if (hourOfTheDay < 18)
            {
                output = $"Good Afternoon {firstName}";
            }
            else
            {
                output = $"Good Evening {firstName}";
            }

            return output;
        }
    }
}
