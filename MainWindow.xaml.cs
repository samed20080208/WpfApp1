using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Color randomColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            btn1.Background = brush;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Color randomColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            btn2.Background = brush;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Color randomColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            btn3.Background = brush;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Color randomColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            btn5.Background = brush;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Color randomColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            btn4.Background = brush;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Color randomColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            btn6.Background = brush;
        }

        private void btn6_delete(object sender, MouseButtonEventArgs e)
        {
            btn6.Visibility = Visibility.Collapsed;
            this.Title = "6";
        }

        private void btn5_delete(object sender, MouseButtonEventArgs e)
        {
            btn4.Visibility = Visibility.Collapsed;
            this.Title = "4";
        }

        private void btn4_delete(object sender, MouseButtonEventArgs e)
        {
            btn5.Visibility = Visibility.Collapsed;
            this.Title = "5";
        }

        private void btn3_delete(object sender, MouseButtonEventArgs e)
        {
            btn2.Visibility = Visibility.Collapsed;
            this.Title = "2";
        }

        private void btn2_delete(object sender, MouseButtonEventArgs e)
        {
            btn3.Visibility = Visibility.Collapsed;
            this.Title = "3";
        }

        private void btn1_delete(object sender, MouseButtonEventArgs e)
        {
            btn1.Visibility = Visibility.Collapsed;
            this.Title = "1";
        }
    }
}