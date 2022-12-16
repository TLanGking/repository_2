// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace InputApplication
{
    class Input
    {
        static void Main(string[] args)
        {
            int temp;
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
