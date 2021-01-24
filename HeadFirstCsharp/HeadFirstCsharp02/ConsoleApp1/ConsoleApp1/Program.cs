using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string result = "";
            int x = 3;
            if (x > 2)
                result += "a";
            x--;
            result += "-";
            if (x == 2)
                result += "b c";
            x--;
            result += "-";
            while (x > 0)
            {
                if (x == 1)
                {
                    result += "d";
                    x--;
                }
            }
            Console.WriteLine(result);
        }
    }
}
