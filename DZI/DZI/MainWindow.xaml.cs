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

namespace DZI
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
        double DevineMethod(double height, string gender)
        {
            double answer = 0.0;
            switch (gender)
            {
                case "Мужской":
                    answer = 50 + 2.3 * (0.394 * height - 60);
                    break;
                case "Женский":
                    answer = 45.5 + 2.3 * (0.394 * height - 60);
                    break;

                default:
                    MessageBox.Show("Укажите пол");
                    break;
            }

            return answer;
        }
        double RobinsonMethod(double height, string gender)
        {
            double answer = 0.0;
            switch (gender)
            {
                case "Мужской":
                    answer = 52 + 1.9 * (0.394 * height - 60);
                    break;
                case "Женский":
                    answer = 49 + 1.7 * (0.394 * height - 60);
                    break;

                default:
                    MessageBox.Show("Укажите пол");
                    break;
            }

            return answer;
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {

            double hg = Convert.ToDouble(tbHeight.Text);
            double g = Convert.ToDouble(tbHeight.Text);


            switch (cbMethod.Text)
            {
                case "Devine":
                    string text = DevineMethod(hg, cbGender.Text).ToString();
                    lblimt.Content = text;
                    DevineMethod(hg, cbGender.Text);
                    break;
                case "Robinson":
                    lblimt.Content = $"Ваш ИМТ: {RobinsonMethod(hg, cbGender.Text)} ";
                    break;
                default:
                    MessageBox.Show("Выберите метод");
                    break;
            }
        }

        private void cbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}