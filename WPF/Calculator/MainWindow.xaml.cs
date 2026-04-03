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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        private double firstNum = 0;
        private string operation = "";
        private double SecondNum = 0;
        private bool isNewNumber = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
            firstNum = 0;
            operation = "";
            SecondNum = 0;
        }
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewNumber)
            {
                Display.Text = btn.Content.ToString();
                isNewNumber = false;
            }
            else
            {
                Display.Text += btn.Content.ToString();
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            firstNum = double.Parse(Display.Text);
            operation = btn.Content.ToString();
            isNewNumber = true;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            SecondNum = double.Parse(Display.Text);
            double result = 0;

            switch (operation)
            {
                case "+": result = firstNum + SecondNum; break;
                case "-": result = firstNum - SecondNum; break;
                case "*": result = firstNum * SecondNum; break;
                case "/": result = firstNum / SecondNum; break;

                case "^": result = Math.Pow(firstNum, SecondNum); break;
                case "%": result = firstNum % SecondNum; break;

                case "Sin": result = Math.Sin(firstNum); break;
                case "Cos": result = Math.Cos(firstNum); break;
                case "Sqrt": result = Math.Sqrt(firstNum); break;
            }

            Display.Text = result.ToString("0.########");
            isNewNumber = true;
        }

        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Contains(",")) return;

            Button btn = (Button)sender;

            Display.Text += btn.Content.ToString();
        }
    }
}