using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalcOdometr
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTravaled;
        double reimburseRate = .39;
        double amountOwed;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
            if (endingMileage > startingMileage)
            {
                milesTravaled = endingMileage - startingMileage;
                amountOwed = milesTravaled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
            else
                MessageBox.Show("Начальный пробег не может превышать конечный", "Cannot Calculate");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTravaled + " miles", "Miles Traveled");
        }
    }
}
