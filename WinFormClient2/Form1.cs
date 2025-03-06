using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            if (radioButton1.Checked == true)
            {
                textBox3.Text = MathsLibrary.Calculator.Addition(FirstNumber, SecondNumber).ToString();
            }
            else if (radioButton2.Checked == true)
            {
                textBox3.Text = MathsLibrary.Calculator.Substraction(FirstNumber, SecondNumber).ToString();
            }
            else if (radioButton3.Checked == true)
            {
                textBox3.Text = MathsLibrary.Calculator.Multiplication(FirstNumber, SecondNumber).ToString();
            }
            else if (radioButton4.Checked == true)
            {
                textBox3.Text = MathsLibrary.Calculator.Division(FirstNumber, SecondNumber).ToString();
            }
            else
            {
                textBox3.Text = "Invalid operator";
            }
        }
    }
}
