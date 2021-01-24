using System;

namespace Swimpool1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string poem = "";
            while (x < 4)
            {
                poem += "a";
                if (x < 1)
                    poem += " ";
                poem += "n";
                if (x < 1)
                {
                    poem += "oise ";
                    x = x - 1;
                }
                if (x == 1)
                    poem += "noys ";
                if (x > 1)
                    poem += " oyster";
                x = x + 2;
            }
            Console.WriteLine(poem);
        }
    }
}
