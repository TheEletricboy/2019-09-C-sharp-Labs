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
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows;
using lab_facial_recognition_forms;


namespace lab_facial_recognition_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        lab_facial_recognition_forms.Form1 newForm;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Hide();
            //Form1 form = new Form1();
            //form.ShowDialog();
            //Close();

            newForm = new lab_facial_recognition_forms.Form1();
            newForm.Show();

        }
    }
}
