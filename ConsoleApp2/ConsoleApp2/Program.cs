// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//C# 基本语法
using System;
namespace RectangleAppication
{
    class Rectangle
    {
        double length;
        double width;
        public void Acceptdetials()
        {
            length = 3.14;
            width = 2.71;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("length:{0}", length);
            Console.WriteLine("width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());
        }
    }

    class ExcuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetials();
            r.GetArea();
            r.Display();
            Console.ReadLine();
        }
    }
}