using System;
using System.Collections.Generic;
using System.Linq;
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
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Windows.Forms;

namespace lab_facial_recognition_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // private ImageBox m_ImgBox;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Image<Bgr, Byte> image = new Image<Bgr, Byte>("lena.jpg");
            image.Draw(new System.Drawing.Rectangle(100, 100, 200, 200), new Bgr(0, 0, 255), 2);
            Image<Gray, Byte> imgGray = image.Convert<Gray, Byte>();
            Image<Gray, Byte> cannyEdges = imgGray.Canny(new Gray(128), new Gray(20));
            imgBox.Image = image;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // That would be the code to do it at runtime...
            // System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
            // m_ImgBox = new ImageBox();
            // host.Child = m_ImgBox;
            // imageGrid.Children.Add(host);
        }
    }
}
