using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Windows;

namespace ConverterApp
{
    public partial class MainWindow : Window
    {
        private string[] currencies;

        public MainWindow()
        {
            InitializeComponent();

        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string apiKey = "b384bbfef1edbfc27b335b9f";
            string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";

            using HttpClient client = new HttpClient();

            try
            {
                string response = await client.GetStringAsync(url);
                var data = JObject.Parse(response);

                var rates = data["conversion_rates"] as JObject;
                currencies = rates.Properties().Select(p => p.Name).ToArray();

                comboFrom.ItemsSource = currencies;
                comboTo.ItemsSource = currencies;

                comboFrom.SelectedIndex = 0;
                comboTo.SelectedIndex = 1;
            } 
            catch
            {
                MessageBox.Show("Ошибка при получении данных валют");
            }
        }

        private async void Convert_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("Введите число!");
                return;
            }

            string apiKey = "b384bbfef1edbfc27b335b9f";

            string from = comboFrom.SelectedItem.ToString();
            string to = comboTo.SelectedItem.ToString();

            string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/{from}";

            using HttpClient client = new HttpClient();

            try
            {
                string response = await client.GetStringAsync(url);
                var data = JObject.Parse(response);

                double rate = (double)data["conversion_rates"][to];
                double result = amount * rate;

                txtResult.Text = $"{amount} {from} = {result} {to}";
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных");
            }
        }
    }
}