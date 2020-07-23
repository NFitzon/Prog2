using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Uebung1
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
        string verlauf = "";
        string ergebnis = "";

        private void Button_Click_Number(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            verlauf += btn.Content;
            tbl_Verlauf.Text = verlauf;
         }
        private void Button_Click_c(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            verlauf = "";
            tbl_Verlauf.Text = verlauf;
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            string operations_pattern = @"(\d+)\s{0,1}(\\+|-|\*|\/){1}s{0,1}(\d+)";
            Regex operation = new Regex(operations_pattern);
            Match match = operation.Match(operations_pattern);
            if(operation.IsMatch(operations_pattern) == true)
            {
                double result = 0;
                if (match.Groups[2].Value == "+") {
                    result = Double.Parse(match.Groups[1].Value) + Double.Parse(match.Groups[3].Value);
                    tbl_Verlauf.Text = verlauf + "\n" + result;
                }
                if (match.Groups[2].Value == "-") { }
                if (match.Groups[2].Value == "*") { }
                if (match.Groups[2].Value == "/") { }
            }
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            verlauf += btn.Content;
            tbl_Verlauf.Text = verlauf;
        }

        private void btn_x_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_slash_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_potenz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_sqrt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_comma_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
