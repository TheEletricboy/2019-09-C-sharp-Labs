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

namespace lab_18_entity_framework
{
    

    

    public partial class MainWindow : Window
    {

        public Customer model01 = new Customer();

        public MainWindow()
        {
            InitializeComponent();
        }

        


        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

            Clear();


        }
        void Clear()
        {

            txtFirstName.Text = txtLastName.Text = txtCity.Text = txtAddress.Text = "";     //we make the string as NOTHING
            //btnSave.Content = "Save";
            btnDelete.IsEnabled = false;
            model01.CustomerId = 0;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Clear();    //when loading it sets everything from the clear function

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            model01.FirstName = txtFirstName.Text.Trim(); //trim is used to remove white spaces from the left and right sides of the txtBox
            model01.LastName = txtLastName.Text.Trim();
            model01.City = txtCity.Text.Trim();
            model01.Address = txtAddress.Text.Trim();

            var model = new Customer() { };

            using (DBEntities db = new DBEntities())
            {
                db.Customers.Add(model);
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Submited Successfully!");
        }

        private void CustomerGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
