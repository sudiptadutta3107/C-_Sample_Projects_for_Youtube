using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfClient;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        double FirstNumber = double.Parse(textBox1.Text);

        double SecondNumber = double.Parse(textBox2.Text);

        if (radioButton1.IsChecked == true)
        {
            textBox3.Text = MathsLibrary.Calculator.Addition(FirstNumber, SecondNumber).ToString();
        }
        else if (radioButton2.IsChecked == true)
        {
            textBox3.Text = MathsLibrary.Calculator.Substraction(FirstNumber, SecondNumber).ToString();
        }
        else if (radioButton3.IsChecked == true)
        {
            textBox3.Text = MathsLibrary.Calculator.Multiplication(FirstNumber, SecondNumber).ToString();
        }
        else if (radioButton4.IsChecked == true)
        {
            textBox3.Text = MathsLibrary.Calculator.Division(FirstNumber, SecondNumber).ToString();
        }
        else
        {
            textBox3.Text = "Invalid operator";
        }
    }
}