using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMICalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private float height, weight, bodyMassIndex;
        private string name = "";

        public MainWindow()
        {
            InitializeComponent();

        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {


        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Taking input from user
            if(float.TryParse((heightTxtBox.Text), out float parsedHeight))
            {

            }
            else
            {
                MessageBox.Show("Enter Valid height please", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (float.TryParse((weightTxtBox.Text), out float parsedWeight))
            {

            }
            else
            {
                MessageBox.Show("Enter Valid height please", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            string BMI = BMICalculation(parsedWeight, parsedHeight);

            // Checking if name textbox is empty and assign it to a value
            if(nameTxtBox.Text == "")
            {
                name = "User";
            }
            else
            {
                name = nameTxtBox.Text.ToString();
            }

            // Display
            resultLabel.Content = $"Hello {name}, your BMI is ";
        }

        public string BMICalculation(float num1, float num2)
        {
            bodyMassIndex = (num1) / (num2 * num2);
            return bodyMassIndex.ToString();
        }

        
    }
}
