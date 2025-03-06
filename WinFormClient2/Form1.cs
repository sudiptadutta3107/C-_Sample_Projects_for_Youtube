using System;
using System.Windows.Forms;

namespace WinFormClient2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double FirstNumber = double.Parse(textBox1.Text);

            double SecondNumber = double.Parse(textBox2.Text);

            double result = MathsLibrary.Calculator.Addition(FirstNumber, SecondNumber);

            textBox3.Text = result.ToString();

        }
    }
}
