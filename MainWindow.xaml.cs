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

namespace CursoNicosiored_P5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const float _BREAD_PRICE = 10;
        private const float _MEAT_PRICE = 20;
        private const float _TOMATO_PRICE = 5;
        private const float _LETTUCE_PRICE = 3;
        private const float _CHEESE_PRICE = 8;
        private int _burgers = 1;

        private float _total;

        public MainWindow()
        {
            InitializeComponent();

            P_Bread_Click(null, null);
            P_Meat_Click(null, null);
            P_Tomato_Click(null, null);
            P_Lettuce_Click(null, null);
        }

        private void AddTotal(float price, int burgers)
        {
            _total += price * burgers;
            P_Total.Text = "Total: $" + _total.ToString();
        }

        private void P_Bread_Click(object sender, RoutedEventArgs e)
            => AddTotal(P_Bread.IsChecked.GetValueOrDefault() ? _BREAD_PRICE : -_BREAD_PRICE, _burgers);

        private void P_Meat_Click(object sender, RoutedEventArgs e)
            => AddTotal(P_Meat.IsChecked.GetValueOrDefault() ? _MEAT_PRICE : -_MEAT_PRICE, _burgers);

        private void P_Tomato_Click(object sender, RoutedEventArgs e)
            => AddTotal(P_Tomato.IsChecked.GetValueOrDefault() ? _TOMATO_PRICE : -_TOMATO_PRICE, _burgers);

        private void P_Lettuce_Click(object sender, RoutedEventArgs e)
            => AddTotal(P_Lettuce.IsChecked.GetValueOrDefault() ? _LETTUCE_PRICE : -_LETTUCE_PRICE, _burgers);

        private void P_Cheese_Click(object sender, RoutedEventArgs e)
            => AddTotal(P_Cheese.IsChecked.GetValueOrDefault() ? _CHEESE_PRICE : -_CHEESE_PRICE, _burgers);

        private void Substract_Button_Click(object sender, RoutedEventArgs e)
        {
            if (_burgers > 1)
            {
                float toSubstract = -(_total / _burgers);
                _burgers--;
                AddTotal(toSubstract, 1);
                P_Burgers.Text = "Burgers: " + _burgers;
            }
        }

        private void Addition_Button_Click(object sender, RoutedEventArgs e)
        {
            if (_burgers <= int.MaxValue)
            {
                float toAdd = _total / _burgers;
                _burgers++;
                AddTotal(toAdd, 1);
                P_Burgers.Text = "Burgers: " + _burgers;
            }
        }

        private void Order_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Congratulations! You have ordered a burger!", "Order", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            this.Close();
        }
    }
}
