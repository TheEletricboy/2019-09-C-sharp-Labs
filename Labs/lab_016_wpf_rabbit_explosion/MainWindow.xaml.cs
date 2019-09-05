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
using System.Windows.Threading;

namespace lab_016_wpf_rabbit_explosion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer timer = new DispatcherTimer();
        
        
        public MainWindow()
        {
            InitializeComponent();
            Initialise();

            
        }

        void Initialise() {
            Button01.Content = "Click Here";
            
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Tick += changeColour;
        }

        void changeColour(object sender, EventArgs e)
        {
            Random r = new Random();
            var randomColour = Label01.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
        }
        




        
        static int counter = 0;
        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            
            counter++;
            timer.Start();
            
            if (Rabbit01.Visibility == Visibility.Visible)
            {
                Rabbit01.Visibility = Visibility.Hidden;
                
            }
            else
            {
                Rabbit01.Visibility = Visibility.Visible;
                

            }

            //random color generator
            //for (int i = 0; i < 100_000; i++)
            //{
            //    Label01.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            //}
            
        }
    }
}
