// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace OperatorApplication
{
    class Rectangle
    {
        double length;
        double width;
        public void InitRectangle()
        {
            this.length = 3.14;
            this.width = 6.6;
        }
    }
    class Operator
    {
        static void Main(string[] args)
        {
            //typeof()
            Console.WriteLine(typeof(Rectangle));
            //is
            Rectangle r;
            r.InitRectangle();
            if (r is Rectangle)
            {
                Console.WriteLine("r is Rectangle!");
            }
        }
    }
}