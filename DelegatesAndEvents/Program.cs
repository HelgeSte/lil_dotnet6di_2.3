// See https://aka.ms/new-console-template for more information
using DelegatesAndEvents;

namespace DelegatesAndEvents
{
    class Program
    {
        // Using the Func delegate
        static Func<int, int, int> add = (a, b) => a + b;
        static void addme(Func<int, int, int> myFunc, int num1, int num2) { Console.WriteLine($"result = {myFunc(num1, num2)}"); } // myFunc = callback

        // Using the Action delegate 
        static Action<string> print = message => Console.Write(message);
        static void printMe(Action<string> myAction, string str1) { myAction("Hello, "); myAction(str1); } // myAction = callback

        public static void useMyDelegate(myDelegate myDel) // Using callback
        {
            myDel("Hello from myDelegate");
        }

        public delegate void myDelegate(string s);
        

        static void Main(string[] args)
        {
            Delegate del = WriteHello; // works like a pointer to a function
            del.DynamicInvoke("Helge");

            DelegateSample.PassMeWork(WriteHello); // DelegateSample.PassMeWork(Delegate function )

            Console.WriteLine($"result = {add(3, 4)}");
            addme(add, 5, 9); // Using callback

            print("Hei\n");

            printMe(print, "world!"); // Using callback

            useMyDelegate(WriteHello);
        }
        static void WriteHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}






