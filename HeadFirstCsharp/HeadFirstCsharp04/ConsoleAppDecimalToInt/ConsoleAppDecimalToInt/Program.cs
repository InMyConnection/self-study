using System;

namespace ConsoleAppDecimalToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal myDecimalValue = 10;
            int myIntValue = (int)myDecimalValue;
            Console.WriteLine("The myIntValue is " + myIntValue);
            long x = 139401930;
            Console.WriteLine("Ответ " + x);
            Console.WriteLine(x);
        }
    }
}
