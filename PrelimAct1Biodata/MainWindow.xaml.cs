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

namespace PrelimAct1Biodata
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
        private void resetBttn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you wish to reset the form?", "NOTICE!", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                //clears all textbox
                nameBox.Text = "";
                nameBox1.Text = "";
                nameBox2.Text = "";
                addressBox.Text = "";
                addressBox1.Text = "";
                datePicker1.Text = "";
                ageBox.Text = "";
                nationBox.Text = "";
                contactBox.Text = "";
                //renables buttons
                singleBttn.IsEnabled = true;
                marriedBttn.IsEnabled = true;
                fmaleBttn.IsEnabled = true;
                maleBttn.IsEnabled = true;
            }
            else {
                
            }
        }
        private void cancelBttn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you wish to cancel the form?", "NOTICE!", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
            else
            {
            
            }
        }
        private void maleBttn_Click(object sender, RoutedEventArgs e)
        {
            fmaleBttn.IsEnabled = false;
        }
        private void fmaleBttn_Click(object sender, RoutedEventArgs e)
        {
            maleBttn.IsEnabled = false;
        }
        private void singleBttn_Click(object sender, RoutedEventArgs e)
        {
            marriedBttn.IsEnabled = false;
        }
        private void marriedBttn_Click(object sender, RoutedEventArgs e)
        {
            singleBttn.IsEnabled = false;
        }

        private void saveBttn_Click(object sender, RoutedEventArgs e)
        {

            string name = "Name: "+nameBox.Text.ToUpper() + " " + nameBox2.Text.ToUpper() + ". "+ nameBox1.Text.ToUpper();
            string address = "Address: " + addressBox.Text.ToUpper() + ", " + addressBox1.Text.ToUpper();
            string birthday = "Birthday: " + datePicker1.Text.ToUpper();
            string age = "Age: " + ageBox.Text.ToUpper();
            string gender = "Gender: FEMALE";
            string status = "Civil status: MARRIED";
            string nation = "Nationality: " + nationBox.Text.ToUpper();
            string contact = "Contact: " + contactBox.Text.ToUpper();
            if (maleBttn.IsEnabled) {
                gender = "Gender: MALE";
            }
            if (singleBttn.IsEnabled)
            {
                status = "Civil status: SINGLE";
            }

            string info = name + "\n" + address + "\n" + birthday + "\n" + age + "\n" + gender + "\n" + status+"\n"+ nation + "\n" + contact;
            MessageBox.Show(info, "Information");
        }
        private void ageBox_KeyDown(object sender, KeyEventArgs e)
        {
            //converts keypressed as boolean value
            var digit = e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab;
            //checks boolean
            if (!digit) {
                ageBox.IsEnabled = false;
                MessageBox.Show("Please enter a valid age!", "NOTICE!");
            }
            ageBox.IsEnabled = true;
        }

        private void famName_KeyPress(object sender, KeyEventArgs e)
        {         
            var digit = e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9;                   
            if (digit)
            {
                nameBox.IsEnabled = false;
                MessageBox.Show("Please enter a proper name!", "NOTICE!");
            }
            nameBox.IsEnabled = true;
        }
        private void firstName_KeyPress(object sender, KeyEventArgs e)
        {            
            var digit = e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9;
            if (digit)
            {
                nameBox1.IsEnabled = false;
                MessageBox.Show("Please enter a proper name!", "NOTICE!");
            }
            nameBox1.IsEnabled = true;
        }
        private void midInitial_KeyPress(object sender, KeyEventArgs e)
        {
            var digit = e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9;
            if (digit)
            {
                nameBox2.IsEnabled = false;
                MessageBox.Show("Please enter a proper name!", "NOTICE!");
            }
            nameBox2.IsEnabled = true;
        }
        private void brgyBox_KeyPress(object sender, KeyEventArgs e)
        {
            var digit = e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9;
            if (digit)
            {
                addressBox.IsEnabled = false;
                MessageBox.Show("Please enter a proper address!", "NOTICE!");
            }
            addressBox.IsEnabled = true;
        }

        private void cityBox_KeyPress(object sender, KeyEventArgs e)
        {
            var digit = e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9;
            if (digit)
            {
                addressBox1.IsEnabled = false;
                MessageBox.Show("Please enter a proper address!", "NOTICE!");
            }
            addressBox1.IsEnabled = true;
        }
        private void nationBox_KeyPress(object sender, KeyEventArgs e)
        {
            var digit = e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9;
            if (digit)
            {
                nationBox.IsEnabled = false;
                MessageBox.Show("Please enter a proper address!", "NOTICE!");
            }
            nationBox.IsEnabled = true;
        }
        private void contactBox_KeyPress(object sender, KeyEventArgs e)
        {
            var digit = e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Tab;
            if (!digit)
            {
                contactBox.IsEnabled = false;
                MessageBox.Show("Please enter a proper number", "NOTICE!");
            }
            contactBox.IsEnabled = true;
        }
    }
}
