﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Guys
{
    class Guy
    {
        public string Name;
        public int Cash;
        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("У меня не хватает денег" + amount, Name + " говорит...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if(amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " мне не нужно", Name + " говорит...");
                return 0;
            }
        }
    }
}
