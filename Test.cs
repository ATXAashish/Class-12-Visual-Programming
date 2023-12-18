using System;

namespace ConsoleApp1
{
    public class Test
    {

        public void Display()
        {
            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle:");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }

}

