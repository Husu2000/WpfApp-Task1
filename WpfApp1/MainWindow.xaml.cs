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

namespace WpfApp1
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

        private void button1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int R = Random.Shared.Next(0,255);
            int G = Random.Shared.Next(0,255);
            int B = Random.Shared.Next(0,255);
            Color color = Color.FromRgb((byte)R,(byte)G,(byte)B);
            button1.Background= new SolidColorBrush(color);
        }

        private void button2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int R = Random.Shared.Next(0, 255);
            int G = Random.Shared.Next(0, 255);
            int B = Random.Shared.Next(0, 255);
            Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
            button2.Background = new SolidColorBrush(color);
        }

        private void button3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int R = Random.Shared.Next(0, 255);
            int G = Random.Shared.Next(0, 255);
            int B = Random.Shared.Next(0, 255);
            Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
            button3.Background = new SolidColorBrush(color);
        }

        private void button4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int R = Random.Shared.Next(0, 255);
            int G = Random.Shared.Next(0, 255);
            int B = Random.Shared.Next(0, 255);
            Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
            button4.Background = new SolidColorBrush(color);
        }

        private void button5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int R = Random.Shared.Next(0, 255);
            int G = Random.Shared.Next(0, 255);
            int B = Random.Shared.Next(0, 255);
            Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
            button5.Background = new SolidColorBrush(color);
        }

        private void button6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int R = Random.Shared.Next(0, 255);
            int G = Random.Shared.Next(0, 255);
            int B = Random.Shared.Next(0, 255);
            Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
            button6.Background = new SolidColorBrush(color);
        }

        private void button1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            button1.Visibility= Visibility.Hidden;
            this.Title= button1.Content.ToString();
        }

        private void button2_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            button2.Visibility = Visibility.Hidden;
            this.Title = button2.Content.ToString();
        }

        private void button3_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            button3.Visibility = Visibility.Hidden;
            this.Title = button3.Content.ToString();
        }

        private void button4_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            button4.Visibility = Visibility.Hidden;
            this.Title = button4.Content.ToString();
        }

        private void button5_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            button5.Visibility = Visibility.Hidden;
            this.Title = button5.Content.ToString();
        }

        private void button6_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            button6.Visibility = Visibility.Hidden;
            this.Title = button6.Content.ToString();
        }
    }
}
