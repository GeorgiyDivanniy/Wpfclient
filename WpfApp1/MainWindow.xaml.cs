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
using ConsoleApp1;

namespace WpfApp1
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
        Beverage beverage;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            if (pressed.Name == "Americano")
            {
                imageType.Source = new BitmapImage(new Uri("C:\\Users\\Sergey\\OneDrive\\ИСРП\\Projects\\01\\WpfApp1\\Americano.jpeg", UriKind.Absolute));
            }
            if (pressed.Name == "Cappuccino")
            {
                imageType.Source = new BitmapImage(new Uri("C:\\Users\\Sergey\\OneDrive\\ИСРП\\Projects\\01\\WpfApp1\\Cappuccino.jpg", UriKind.Absolute));
            }
            if (pressed.Name == "Espresso")
            {
                imageType.Source = new BitmapImage(new Uri("C:\\Users\\Sergey\\OneDrive\\ИСРП\\Projects\\01\\WpfApp1\\Espresso.jpg", UriKind.Absolute));
            }
            if (pressed.Name == "Cocoa")
            {
                imageType.Source = new BitmapImage(new Uri("C:\\Users\\Sergey\\OneDrive\\ИСРП\\Projects\\01\\WpfApp1\\Cocoa.jpg", UriKind.Absolute));
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox check = (CheckBox)sender;

            if(check.Name =="milk" && check.IsChecked == true)
            {
                imageMikl.Visibility = Visibility.Visible;
                imageMikl.Source = new BitmapImage(new Uri("C:\\Users\\Sergey\\OneDrive\\ИСРП\\Projects\\01\\WpfApp1\\Milk.jpg", UriKind.Absolute));
            }
            else if (check.Name == "milk")
            {
                imageMikl.Visibility = Visibility.Hidden;
            }

            if (check.Name == "sugar" && check.IsChecked == true)
            {
                imageSugar.Visibility = Visibility.Visible;
                imageSugar.Source = new BitmapImage(new Uri("C:\\Users\\Sergey\\OneDrive\\ИСРП\\Projects\\01\\WpfApp1\\Sugar.jpg", UriKind.Absolute));
            }
            else if (check.Name == "sugar")
            {
                imageSugar.Visibility = Visibility.Hidden;
            }
        }

        private void inMoneyButton(object sender, RoutedEventArgs e)
        {
            if (inputMoney.Text != "")
            {
                inputtedMoney.Content = "Внесенная сумма: " + double.Parse(inputMoney.Text.ToString());
            }
        }

        private void ClickOK(object sender, RoutedEventArgs e)
        {


            if(Americano.IsChecked == true)
            {
                beverage = new Americano();
            }

            if (Cappuccino.IsChecked == true)
            {
                beverage = new Cappuccino();
            }

            if (Espresso.IsChecked == true)
            {
                beverage = new Espresso();
            }

            if (Cocoa.IsChecked == true)
            {
                beverage = new Cocoa();
            }



            if (sugar.IsChecked == true)
            {
                beverage = new Milk(beverage);
            }
            if(milk.IsChecked == true)
            {
                beverage = new Sugar(beverage);
            }
            if(inputMoney.Text != "")
            {
                inputtedMoney.Content = "Внесенная сумма: " + double.Parse(inputMoney.Text.ToString());

                costBeverage.Content = "Цена напитка: " + beverage.cost();

                changeLable.Content = "Сдача: " + (double.Parse(inputMoney.Text.ToString()) - beverage.cost());

            }



        }

    }
}
