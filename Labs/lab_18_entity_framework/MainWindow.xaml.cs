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

        public Table model01 = new Table();

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
            btnSave.Content = "Save";
            btnDelete.IsEnabled = false;
            model01.CustomerId = 0;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Clear();    //when loading it sets everything from the clear function
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var obj = new Table();
            obj.FirstName = txtFirstName.Text.Trim(); //trim is used to remove white spaces from the left and right sides of the txtBox
            obj.LastName = txtLastName.Text.Trim();
            obj.City = txtCity.Text.Trim();
            obj.Address = txtAddress.Text.Trim();

            //model01.FirstName = txtFirstName.Text.Trim(); //trim is used to remove white spaces from the left and right sides of the txtBox
            //model01.LastName = txtLastName.Text.Trim();
            //model01.City = txtCity.Text.Trim();
            //model01.Address = txtAddress.Text.Trim();

            using (EFDBEntities db = new EFDBEntities())
            {
                db.Tables.Add(obj);
                db.SaveChanges();
                var userToUpdate = db.Tables.Find(obj.CustomerId);
            }
            Clear();
            MessageBox.Show("Submited Successfully!");
        }

        

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DgvCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //DataGridTextColumn textColumn = new DataGridTextColumn();
            //textColumn.Header = "First Name";
            //textColumn.Binding = new Binding("FirstName");
            //DgvCustomer.Columns.Add(textColumn);
        }

        void PopulateDataGridView()
        {
            
        }
    }
}
