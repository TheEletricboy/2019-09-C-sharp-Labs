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

namespace lab_19_rabbits_Database_CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Rabbit> rabbits;
        static Rabbit rabbit = new Rabbit();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise(){


            //using : automatic cleanup(C# does not know inherently when we're done
            //and clean all memory)
            using (var db = new RabbitDbEntities())
            {
                rabbits = db.Rabbits.ToList();
            }
            //fancy lamba to a) loop rabbits, b) each loop, add item to listbox on screen
            //get the list of rabbits. for each rabbit in the list of rabbits do the following
            rabbits.ForEach (rabbit => ListBoxRabbit.Items.Add(rabbit)) ;
            //BINDING METHDO: Bind list box to database(better)
            //ListBoxRabbit.ItemsSource = rabbits;
            TextBoxName.IsReadOnly = true;
            TextBoxAge.IsReadOnly = false;

            ButtonEdit.IsEnabled = false;
            ButtonDelete.IsEnabled = false;
            

        }

        private void ListBoxRabbit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxRabbit.SelectedItem != null) //when deselect a rabbit, dont run this code
            {
                //whenever we select an item in the list, cast it from object type and
                //put it as Rabbit type, put it in the gloval 'rabbit' variable
                rabbit = (Rabbit)ListBoxRabbit.SelectedItem;
                TextBoxName.Text = rabbit.Name;
                TextBoxAge.Text = rabbit.Age.ToString();
            }
            
            

            //enable EDIT and DELETE
            ButtonEdit.IsEnabled = true;
            ButtonDelete.IsEnabled = true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (ButtonAdd.Content.Equals("Add"))
            {
                ButtonAdd.Content = "Save";
                ButtonEdit.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF1D3A"));
                //clear boxes and set to white
                TextBoxName.Text = "";
                TextBoxAge.Text = "";
                TextBoxName.Background = (SolidColorBrush)Brushes.White;
                TextBoxAge.Background = (SolidColorBrush)Brushes.White;
                TextBoxName.IsReadOnly = false;
                TextBoxAge.IsReadOnly = false;
                ButtonEdit.IsEnabled = false;
                ButtonDelete.IsEnabled = false;
            }
            else
            {
                ButtonEdit.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FBFCFC"));
                ButtonAdd.Content = "Add";
                TextBoxName.IsReadOnly = true;
                TextBoxAge.IsReadOnly = true;
                //commit changes
                if (TextBoxName.Text.Length > 0 && TextBoxAge.Text.Length >0)
                {
                    if (int.TryParse(TextBoxAge.Text, out int age))
                    {
                        var RabbitToAdd = new Rabbit()
                        {
                            Name = TextBoxName.Text, 
                            Age = age
                        };

                        using (var db = new RabbitDbEntities())
                        {
                            db.Rabbits.Add(RabbitToAdd);
                            db.SaveChanges();
                            //update view
                            rabbit = null;
                            rabbits = db.Rabbits.ToList();
                            ListBoxRabbit.Items.Clear();
                            ListBoxRabbit.ItemsSource = rabbits;
                        }

                    }
                    
                    
                }
                    
                
            }
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonEdit.Content.Equals("Edit"))
            {
                Color color = (Color)ColorConverter.ConvertFromString("#007ED9");
                var brush = new SolidColorBrush(color);

                ButtonEdit.Background = brush;
                ButtonEdit.Content = "Save";

                TextBoxName.IsReadOnly = false;
                TextBoxAge.IsReadOnly = false;

                ButtonAdd.IsEnabled = false;
                TextBoxName.Focus();
                TextBoxName.SelectAll();
            }
            else
            {
                ButtonEdit.Content = "Edit";
                if ((TextBoxAge.Text.Length > 0) && (TextBoxName.Text.Length >0))
                {
                    if (rabbit != null)
                    {
                        rabbit.Name = TextBoxName.Text;
                        if (int.TryParse(TextBoxAge.Text, out int age))
                        {
                            rabbit.Age = age;
                        }

                        
                        using (var db = new RabbitDbEntities())
                        {
                            //read rabbit from database by the ID
                            var rabbitToUpdate = db.Rabbits.Find(rabbit.RabbitId);
                            //update the rabbit and save it back to DB
                            rabbitToUpdate.Name = rabbit.Name;
                            rabbitToUpdate.Age = rabbit.Age;
                            //save it back to db
                            db.SaveChanges();
                            //Clear list box because we will change it
                            rabbit = null;
                            ListBoxRabbit.ItemsSource = null;   //remove binding
                            ListBoxRabbit.Items.Clear();    //clears it

                            //repopulate list box
                            rabbits = db.Rabbits.ToList();
                            ListBoxRabbit.ItemsSource = rabbits;
                        }

                    }
                }
                ButtonAdd.IsEnabled = false;
                
            }


        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonDelete.Content.Equals("Delete"))
            {
                ButtonDelete.Content = "Confirm Delete";
            }
            else
            {
                //delete record
                //Find records in database which matches selected rabbit
                if (rabbit !=null)
                {
                    using (var db = new RabbitDbEntities())
                    {
                        var rabbitToDelete = db.Rabbits.Find(rabbit.RabbitId);

                        db.Rabbits.Remove(rabbitToDelete);

                        db.SaveChanges();
                        //Clear list box because we will change it
                        rabbit = null;
                        ListBoxRabbit.ItemsSource = null;   //remove binding
                        ListBoxRabbit.Items.Clear();    //clears it

                        //repopulate list box
                        rabbits = db.Rabbits.ToList();
                        ListBoxRabbit.ItemsSource = rabbits;
                    };
                }


                ButtonDelete.Content = "Delete";
            }
        }
    }
}
