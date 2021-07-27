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

namespace ClassesAndObjects
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

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(entryBox.Text))
            {
                MessageBox.Show("Please provide the first name", "Name error 01");
            }
            else if(string.IsNullOrEmpty(lastNameEntry.Text.ToString())){
                MessageBox.Show("Please provide the last name", "Name error 02");
            }
            else
            {
                string lastNameString = middleNameEntry.Text != null ? middleNameEntry.Text.ToString() : "noMiddleName";

                string firstName = entryBox.Text.ToString();
                string lastName = lastNameEntry.Text.ToString();

                FullNames fullNames = new FullNames();

                string full = fullNames.fullnames(firstName,lastNameString,lastName).ToString();
                listBox.Items.Add(full);
            }
        }
    }
}
