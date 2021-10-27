using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string result = "";
         
            for (int i = value.Length-1; i >= 0; i--)
            {
                result += value[i];
            }
            Console.WriteLine(result);
        }
    }
}
