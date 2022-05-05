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
            float.TryParse((heightTxtBox.Text), out float parsedHeight);
            float.TryParse((weightTxtBox.Text), out float parsedWeight);
            string BMI = BMICalculation(parsedWeight, parsedHeight);

            name = nameTxtBox.Text.ToString();

            
        }

        public string BMICalculation(float num1, float num2)
        {
            bodyMassIndex = (num1) / (num2 * num2);
            return bodyMassIndex.ToString();
        }

        
    }
}
