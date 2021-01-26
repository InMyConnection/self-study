using System;

namespace ConsoleAppSwimpool3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] islands = new string[4];
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";
            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;
            string result = "";
            int y = 0;
            int refNum;
            while (y < 4)
            {
                refNum = index[y];
                result += "\nisland = ";
                result += islands[refNum];
                y++;
            }
            Console.WriteLine(result);
        }
    }
}
