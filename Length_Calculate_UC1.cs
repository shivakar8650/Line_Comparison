using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison
{
    class Length_Calculate_UC1
    {
        public  double x1, y1, x2, y2;
      
        public void calculate_length()
        {
            Console.WriteLine("Welcome to Line Computation Program.");
            Console.Write("Enter X1 :");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y1 :");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter X2 :");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y2 :");
            y2 = Convert.ToDouble(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length of line is :" + length);
            
        }


    }
}
