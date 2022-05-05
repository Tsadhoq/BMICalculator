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
            resultLabel.Content = "";
            heightTxtBox.Text = "";
            weightTxtBox.Text = "";
            bodyMassIndex = 0;
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

            float BMI = BMICalculation(parsedWeight, parsedHeight);

            // Using method to check condition for BMI
            string bmiState = CheckBMIClassification(BMI);

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
            resultLabel.Content = $"Hello {name}, your Body Mass Index (BMI) is {BMI}.\n";

            // Display condition of BMI and current state
            resultLabel.Content = $"";
        }

        // Methods
        public float BMICalculation(float num1, float num2)
        {
            bodyMassIndex = (num1) / (num2 * num2);
            return bodyMassIndex;
        }

        public string CheckBMIClassification(float bmiNumber)
        {
            if(bmiNumber < 18.5)
            {
                return "BMI Class: Underweight\nObesity Class: -\nDisease Risk: -\nWaist Circumference: -";
            }
            else if(bmiNumber >= 18.5 && bmiNumber <= 24.9)
            {
                return "BMI Class: Normal\nObesity Class: -\nDisease Risk: -\nWaist Circumference: -";
            }
            else if(bmiNumber >= 25 && bmiNumber <= 29.9)
            {
                return "BMI Class: Overweight\nObesity Class: -\nDisease Risk: Increased\nWaist Circumference: High";
            }

            else if (bmiNumber >= 30 && bmiNumber <= 34.9)
            {
                return "BMI Class: Obesity\nObesity Class: 1\nDisease Risk: High\nWaist Circumference: Very High";
            }
            else if (bmiNumber >= 25 && bmiNumber <= 29.9)
            {
                return "BMI Class: Obesity\nObesity Class: 2\nDisease Risk: Very High\nWaist Circumference: Very High";
            }
            else
            {
                return "BMI Class: Extreme Obesity\nObesity Class: 3\nDisease Risk: Extremely High\nWaist Circumference: Extremely High";
            }
        }


    }
}
