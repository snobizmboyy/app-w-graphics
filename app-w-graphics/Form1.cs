using System;
using System.Windows.Forms;

namespace CounterApp
{
    public partial class Form1 : Form
    {
        int counter = 0; // переменная счётчика

        public Form1()
        {
            InitializeComponent();
            labelCounter.Text = counter.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            counter++;
            labelCounter.Text = counter.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            counter--;
            labelCounter.Text = counter.ToString();
        }
    }
}