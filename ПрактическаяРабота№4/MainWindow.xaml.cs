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

namespace ПрактическаяРабота_4
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

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            InputX.Clear();
            InputI.Clear();
            LstResult.Items.Clear();
            RadBtnSin.IsChecked = false;
            RadBtnCos.IsChecked = false;
            RadBtnExp.IsChecked = false;
        }

        private void BtnPerform_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(InputX.Text);
            double i = Convert.ToDouble(InputI.Text);
            double E;
            LstResult.Items.Add("Практическая работа №4. Выполнил Волков А.П.");
            LstResult.Items.Add($"X = {x}");
            LstResult.Items.Add($"I = {i}");           
            int n = 0;
            if (RadBtnCos.IsChecked == true) n = 1;
            else if(RadBtnExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if ((i % 2 != 0) && (x < 0)) E = i * Math.Sqrt(Math.Sin(x));
                    else if ((i % 2 == 0) && (x > 0)) E = i/2 * Math.Sqrt(Math.Abs(Math.Sin(x)));
                    else E = Math.Sqrt(Math.Abs(i*Math.Sin(x)));
                    LstResult.Items.Add($"Результат: {E}");
                    break;
                case 1:
                    if ((i % 2 != 0) && (x < 0)) E = i * Math.Sqrt(Math.Cos(x));
                    else if ((i % 2 == 0) && (x > 0)) E = i / 2 * Math.Sqrt(Math.Abs(Math.Cos(x)));
                    else E = Math.Sqrt(Math.Abs(i * Math.Cos(x)));
                    LstResult.Items.Add($"Результат: {E}");
                    break;
                case 2:
                    if ((i % 2 != 0) && (x < 0)) E = i * Math.Sqrt(Math.Exp(x));
                    else if ((i % 2 == 0) && (x > 0)) E = i / 2 * Math.Sqrt(Math.Abs(Math.Exp(x)));
                    else E = Math.Sqrt(Math.Abs(i * Math.Exp(x)));
                    LstResult.Items.Add($"Результат: {E}");
                    break;
                default:
                    LstResult.Items.Add("Решение не найдено");
                    break;
            }
        }

    }
}
