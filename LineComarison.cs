﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonComputation1
{
    internal class LineComarison
    {
        public void Computation() 
        {
            double firstLine = 0;
            double secondLine = 0;
            for (int i = 0; i < 2; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("enter value for first line");
                        firstLine = LineComarison.LenghtOfLine();
                        break;
                    case 1:
                        Console.WriteLine("enter value for second line");
                        secondLine = LineComarison.LenghtOfLine();
                        break;
                }
            }
            Console.WriteLine($"length of first  :{firstLine}");
            Console.WriteLine($"length of second :{secondLine}");
            int check = firstLine.CompareTo(secondLine);

            if (check.Equals (1))
            {
                Console.WriteLine("first line is greater than second");
            }
            else if (check.Equals(-1))
            {
                Console.WriteLine("second line is greater than first ");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }
            Console.ReadLine();
        }
        static double LenghtOfLine()
        {
            Console.WriteLine("\nEnter values for (x1,y1)(x2,y2) co-ordinates to get length of line");
            Console.WriteLine("\nEnter 'x1'");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter 'y1'");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter 'x2'");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter 'y2'");
            double y2 = double.Parse(Console.ReadLine());
            double lenthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return lenthOfLine;
        }
    }
    
}
