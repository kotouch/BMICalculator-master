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
        double BMI;
        double height;
        double weight;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void xClear_Click(object sender, RoutedEventArgs e)
        {
            xLastName.Text = "";
            xFirstName.Text = "";
            xPhone.Text = "";
            xHeight.Text = "";
            xWeight.Text = "";
        }

        private void xSubmit_Click(object sender, RoutedEventArgs e)
        {
            height = Convert.ToDouble(xHeight.Text);
            weight = Convert.ToDouble(xWeight.Text);

            BMI = (weight / Math.Pow(height, 2)) * 703;
            xBMI.Text = Convert.ToString(BMI);

            if (BMI < 18.5)
            {
                //under weight
                xBMIText.Text = "According to CDC.gov you are under weight.";
            }
            else if (BMI > 29.9)
            {
                //obese
                xBMIText.Text = "According to CDC.gov you are obese.";
            }
            else if ( BMI > 24.9)
            {
                //over weight
                xBMIText.Text = "According to CDC.gov you are over weight.";
            }
            else
            {
                //normal
                xBMIText.Text = "According to CDC.gov you are the normal weight.";
            }
        }
    }
}
