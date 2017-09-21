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

namespace Question7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Fields
        private bool addButtonToggle;
        private bool checkBoxToggle;
        private bool addListToggle;

        public MainWindow()
        {
            InitializeComponent();
            addedButton.Visibility = Visibility.Hidden;
            checkBox.Visibility = Visibility.Hidden;
            listBox.Visibility = Visibility.Hidden;
        }

        //Button for the Add Button box.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (addedButton.Visibility == Visibility.Hidden)
            {
                addedButton.Visibility = Visibility.Visible;
                addButtonToggle = true;
            }
            else
            {
                addedButton.Visibility = Visibility.Hidden;
                addButtonToggle = false;
            }
        }

        //Button for the check box.
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (checkBox.Visibility == Visibility.Hidden)
            {
                checkBox.Visibility = Visibility.Visible;
                checkBoxToggle = true;
            }
            else
            {
                checkBox.Visibility = Visibility.Hidden;
                checkBoxToggle = false;
            }
        }

        //Button for the list box.
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Clear listBox
            listBox.Items.Clear();

            if (listBox.Visibility == Visibility.Hidden)
            {
                listBox.Visibility = Visibility.Visible;
                addListToggle = true;
            }
            else
            {
                listBox.Visibility = Visibility.Hidden;
                addListToggle = false;
            }

            //Add 10 random numbers to list between 0-9.

            Random r = new Random();
            List<int> randomNumbers = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                int n = r.Next(10);
                randomNumbers.Add(n);
                listBox.Items.Add(n);
            }
        }

        /// <summary>
        /// When Report button is pressed, this function will check the boolean toggles on the three buttons
        /// and show a message stating which toggles are on. This function will also change the font of the 
        /// toggled on buttons to the colour red.
        /// </summary>
        
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            String message = "";

            if(addButtonToggle)
            {
                message += "Addbutton\n";
                addedButton.Foreground = Brushes.Red;
            }

            if(checkBoxToggle)
            {
                message += "AddCheckBox\n";
                checkBox.Foreground = Brushes.Red;
            }

            if(addListToggle)
            {
                message += "AddListBox\n";
                listBox.Foreground = Brushes.Red;
            }

            MessageBox.Show(message, "Report");

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
     
        }
        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
