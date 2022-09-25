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

namespace Сalculator
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

        string x = "";
        string y = "";
        string znak = "";
        int result;

        private void BCE_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text = "";
            Tdop.Text = "";

            x = "";
            y = "";
            znak = "";
        }

        private void BC_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text = "";
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text += "1";
            Tdop.Text += "1";
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text += "2";
            Tdop.Text += "2";
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text += "3";
            Tdop.Text += "3";
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text += "4";
            Tdop.Text += "4";
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text += "5";
            Tdop.Text += "5";
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text += "6";
            Tdop.Text += "6";
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text += "7";
            Tdop.Text += "7";
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text += "8";
            Tdop.Text += "8";
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text += "9";
            Tdop.Text += "9";
        }

        private void Bplus_Click(object sender, RoutedEventArgs e)
        {
            Tdop.Text += "+";

            if (x == "") x = Tosnova.Text;
            else y = Tosnova.Text;

            znak = "+";

            Tosnova.Text = "";
        }


        private void Brovno_Click_1(object sender, RoutedEventArgs e)
        {
            if (x == "") MessageBox.Show("no");
            else y = Tosnova.Text;

            Tosnova.Text = "";

            if (x != "" && y != "" && znak != "")
            {
                switch (znak)
                {
                    case "+":
                        result = Convert.ToInt32(x) + Convert.ToInt32(y);
                        Tosnova.Text = result.ToString();
                        x = result.ToString();
                        break;
                    case "-":
                        result = Convert.ToInt32(x) - Convert.ToInt32(y);
                        Tosnova.Text = result.ToString();
                        x = result.ToString();
                        break;
                    case "*":
                        result = Convert.ToInt32(x) * Convert.ToInt32(y);
                        Tosnova.Text = result.ToString();
                        x = result.ToString();
                        break;
                    case "/":
                        result = Convert.ToInt32(x) / Convert.ToInt32(y);
                        Tosnova.Text = result.ToString();
                        x = result.ToString();
                        break;


                    default:
                        break;
                }


            }
        }

        private void Bmines_Click(object sender, RoutedEventArgs e)
        {
            Tdop.Text += "-";

            if (x == "") x = Tosnova.Text;
            else y = Tosnova.Text;

            znak = "-";

            Tosnova.Text = "";
        }

        private void Bmnoj_Click(object sender, RoutedEventArgs e)
        {
            Tdop.Text += "*";

            if (x == "") x = Tosnova.Text;
            else y = Tosnova.Text;

            znak = "*";

            Tosnova.Text = "";
        }

        private void Bdrob_Click(object sender, RoutedEventArgs e)
        {
            Tdop.Text += "/";

            if (x == "") x = Tosnova.Text;
            else y = Tosnova.Text;

            znak = "/";

            Tosnova.Text = "";
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            Tosnova.Text += "0";
            Tdop.Text += "0";
        }

        private void B__Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            for (int i = 0; i < Tosnova.Text.Length - 1; i++)
            {
                str += Tosnova.Text[i];
            }

            Tosnova.Text = str;
        }
    }
}
