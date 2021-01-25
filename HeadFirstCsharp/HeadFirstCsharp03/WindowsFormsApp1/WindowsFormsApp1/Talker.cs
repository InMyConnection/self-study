using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Talker
    {
        public static int BlahBlahBlah (string thingToSay, int numberOfTimes)
        {
            string finalString = "";
            for (int count = 1; count <= numberOfTimes; count++)
            {
                finalString += thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
