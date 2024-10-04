// See https://aka.ms/new-console-template for more information

namespace DelegateIn8Minutes
{
    class Program
    {
        delegate void PrintDelegate(string text);
        static void Main(string[] args)
        {
            PrintDelegate Print = (string text) =>
            {
                Console.WriteLine(text);
            };
            
            Print("Hello smukka!");
            PrintClass.PrintIt("Hola chica");

        }
        
    }
}






