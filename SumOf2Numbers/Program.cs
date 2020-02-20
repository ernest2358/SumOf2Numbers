using System;

namespace SumOf2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number here:");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a 2nd number here:");
            int secondNum = int.Parse(Console.ReadLine());

            int totalNum = firstNum + secondNum;
            Console.Clear();
            Console.WriteLine($"The sum of your 2 numbers: {firstNum} + {secondNum} = {totalNum}");
        }
    }
}
