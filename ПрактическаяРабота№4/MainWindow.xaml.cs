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

        private void BtnClear_Click(object sender, RoutedEventArgs e) // Очищаем все поля и RadioButon
        {
            InputX.Clear(); // Очищает поля ввода x
            InputI.Clear(); // Очищает поля ввода i
            LstResult.Items.Clear(); // очищает окно вывода
            RadBtnSin.IsChecked = false; // отменяет выбор флакжка Sin(x)
            RadBtnCos.IsChecked = false; // отменяет выбор флакжка Cos(x)
            RadBtnExp.IsChecked = false; // отменяет выбор флакжка Exp(x)
        }

        private void BtnPerform_Click(object sender, RoutedEventArgs e) // Основная часть программы
        {
            double x = Convert.ToDouble(InputX.Text); //Передаем значение x из TextBox Name="InputX"
            double i = Convert.ToDouble(InputI.Text); //Передаем значение i из TextBox Name="InputI"
            double E;
            LstResult.Items.Add("Практическая работа №4. Выполнил Волков А.П."); // Вывод рабочее окно (ListBox)
            LstResult.Items.Add($"X = {x}"); // Вывод введенного значения x
            LstResult.Items.Add($"I = {i}"); // Вывод введенного значения i         
            int n = 0; // Переменная для работы RadioButton. Значение n = 0 представляет Sin(x)
            if (RadBtnCos.IsChecked == true) n = 1; // Значение n = 1 представляет Cos(x)
            else if(RadBtnExp.IsChecked == true) n = 2; //Значение n = 2 представляет Exp(x)
            switch (n) // Используем оператор switch со значениями case 0, case 1, case 2
            {
                case 0: // Если выбрано Sin(x)
                    if ((i % 2 != 0) && (x < 0)) E = i * Math.Sqrt(Math.Sin(x));
                    else if ((i % 2 == 0) && (x > 0)) E = i/2 * Math.Sqrt(Math.Abs(Math.Sin(x)));
                    else E = Math.Sqrt(Math.Abs(i*Math.Sin(x)));
                    LstResult.Items.Add($"Результат: {E}");
                    break;
                case 1: // Если выбрано Cos(x)
                    if ((i % 2 != 0) && (x < 0)) E = i * Math.Sqrt(Math.Cos(x));
                    else if ((i % 2 == 0) && (x > 0)) E = i / 2 * Math.Sqrt(Math.Abs(Math.Cos(x)));
                    else E = Math.Sqrt(Math.Abs(i * Math.Cos(x)));
                    LstResult.Items.Add($"Результат: {E}");
                    break;
                case 2: // Если выбрано Exp(x)
                    if ((i % 2 != 0) && (x < 0)) E = i * Math.Sqrt(Math.Exp(x));
                    else if ((i % 2 == 0) && (x > 0)) E = i / 2 * Math.Sqrt(Math.Abs(Math.Exp(x)));
                    else E = Math.Sqrt(Math.Abs(i * Math.Exp(x)));
                    LstResult.Items.Add($"Результат: {E}");
                    break;
                default: // Если не один из case'ов не будет выполнен, тогда выводин на окно вывода "Решений не найдено"
                    LstResult.Items.Add("Решение не найдено");
                    break;
            }
        }

    }
}
