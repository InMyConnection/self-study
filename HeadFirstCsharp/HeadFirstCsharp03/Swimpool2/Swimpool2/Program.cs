using System;

namespace Swimpool2
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
        }
        public static void SayHello()
        {
            string result = "";
            Echo e1 = new Echo();
            Echo e2 = new Echo();
            int x = 0;
            while (x < 4)
            {
                result += e1.Hello() + "\n";
                e1.count += 1;
                if (x == 4)
                    e2.count += 1;
                if (x < 4)
                    e2.count += e1.count;
                x = x + 1;
            }
            Console.WriteLine(result + "Count: " + e2.count);

        }
    }
}
