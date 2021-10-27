using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison
{
    class Compare_Using_Method
    {

        public double x1, y1, x2, y2;
        public double[] length = new double[2];

        public void Compare()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter the end point for line" + (i + 1));
                Console.Write("Enter X1 :");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Y1 :");
                y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter X2 :");
                x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Y2 :");
                y2 = Convert.ToDouble(Console.ReadLine());
                length[i] = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                Console.WriteLine("line" + (i + 1) + " length is :" + length[i]);
            }
            /* if (length[0] == length[1])
                 Console.WriteLine("length of both lines are equal! ");
             else if (length[0] > length[1])
                 Console.WriteLine("length of first line  is greater than second line! ");
             else
                 Console.WriteLine("length of second  line  is greater than first line! ");*/

            int diffrence = length[0].CompareTo(length[1]);
           Boolean checkEqual = length[0].Equals(length[1]);
            if (checkEqual == true)
                Console.WriteLine("Both Lines are equal in length");
            else
                Console.WriteLine("Both are not equal in length");

            if (diffrence == 0)
                Console.WriteLine("Both Lines are equal in length");
            else if (diffrence > 0)
                Console.WriteLine("First Line is greater than Second Line");
            else
                Console.WriteLine("First Line is smaller than Second Line");
        }      
    }
}
