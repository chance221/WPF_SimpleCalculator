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

namespace Wpf_MySimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        public void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            double conversion;
            double inputOz;
            double inputPint;
            double inputQuart;
            double inputCup;
            double inputGallon;
            double inputLiter;

            double inputOz2;
            double inputPint2;
            double inputQuart2;
            double inputCup2;
            double inputGallon2;
            double inputLiter2;

            
            switch (ComboBox_Convert_From.SelectedItem.ToString())
            {
                case "Ounce(s)":
                    inputOz = double.Parse(TextBox_ConvertFrom.Text);
                    break;

                case "Pint(s)":
                    inputPint = double.Parse(TextBox_ConvertFrom.Text);
                    break;

                case "Quart(s)":
                    inputQuart = double.Parse(TextBox_ConvertFrom.Text);
                    break;

                case "Cup(s)":
                    inputCup = double.Parse(TextBox_ConvertFrom.Text);
                    break;

                case "Gallon(s)":
                    inputGallon = double.Parse(TextBox_ConvertFrom.Text);
                    break;

                case "Liter(s)":
                    inputLiter = double.Parse(TextBox_ConvertFrom.Text);
                    break;

            }


            switch (ComboBox_Convert_To.SelectedItem.ToString())
            {
                case "Ounce(s)":
                    inputOz2 = double.Parse(TextBox_ConvertTo.Text);
                    break;

                case "Pint(s)":
                    inputPint2 = double.Parse(TextBox_ConvertTo.Text);
                    break;

                case "Quart(s)":
                    inputQuart2 = double.Parse(TextBox_ConvertTo.Text);
                    break;

                case "Cup(s)":
                    inputCup2 = double.Parse(TextBox_ConvertTo.Text);
                    break;

                case "Gallon(s)":
                    inputGallon2 = double.Parse(TextBox_ConvertTo.Text);
                    break;

                case "Liter(s)":
                    inputLiter2 = double.Parse(TextBox_ConvertTo.Text);
                    break;
            }
            
        }
        //to open up a new window you must create a new object and send the solution to it. 
        // SolutionWindow solutionWindow = new SolutionWindow(conversion);
        // SolutionWindow.ShowDialog();
        private void Button_Help_Click(object sender, RoutedEventArgs e)
        {
            Window1 helpWindow = new Window1();
            helpWindow.ShowDialog();
        }
    }
        
}
