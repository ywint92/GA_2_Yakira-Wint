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

namespace GA_2_Yakira_Wint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Buttons, Labels, and TextBoxes

        public MainWindow()
        {
            InitializeComponent();
            //MainWindow()
        }

        public object Wint { get; private set; }

        private void btnFullName_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            // Declare a third string, full name
            // Concatenate ( combine ) the first and last name into one long string
            string fullName = $"{Yakira} {Wint}";

            // Display full name on button click
            MessageBox.Show(fullName);

        } // btnFullName_Click
    } 

}
