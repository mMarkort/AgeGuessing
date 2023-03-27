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
using System.Text.RegularExpressions;

namespace AgeGuessing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime now = DateTime.Now;
            string text = yearText.Text;

            
            if (Regex.IsMatch(yearText.Text, @"\p{L}"))
            {
                MessageBox.Show("DAMN I TOLD U TO WRITE A YEAR!!!");
            }
            else
            {
                int year = now.Year;
                int enteredYear = Convert.ToInt32(yearText.Text);
                MessageBox.Show($"{Math.Abs(enteredYear - year)}");
            }
        }
    }
}
