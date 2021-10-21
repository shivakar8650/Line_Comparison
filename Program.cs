using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the line comparison program!");

            Length_Calculate_UC1 UC1 = new Length_Calculate_UC1();
            UC1.calculate_length();

            checkEquality_UC2 UC2 = new checkEquality_UC2();
            UC2.checklength();

            compare_length_UC3 UC3 = new compare_length_UC3();
            UC3.compare_lines();

        }
    }
}
