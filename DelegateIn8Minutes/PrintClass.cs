using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateIn8Minutes
{
    internal class PrintClass
    {
        public static void PrintIt(string text)
        {
            PrintDelegate Print = (string text) =>
            {
                Console.WriteLine(text);
                Console.WriteLine(text + text);
            };

            Print("Hello from PrintIt class" + text);

            
        }

        delegate void PrintDelegate(string text);
    }
}
