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
        public object Yakira { get; private set; }
        public object labelName { get; private set; }
        public object txtDisplayLetter { get; private set; }
        public object lblNumberOfLetters { get; private set; }

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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            // Parsing my numbers
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            string sign = "+";
            string equalSign = "=";
            // Doing math with our new int
            int result = num1 + num2;

            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            // Displaying the equation string
            lblEquation.Content = equation;
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            string sign = "-"; // Changes + to -
            string equalSign = "=";
            int result = num1 - num2; // Changed + to -

            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            lblEquation.Content = equation;
        }

        private void txtWord_TextChanged(object sender, TextChangedEventArgs e)
        {
            string usersWord = txtWord.Text; // Getting users word
            int stringLength = usersWord.Length; // Getting how many characters are in the word
            int lastIndex = stringLength - 1; // Getting the last index of the word
            string formatedString = $"Enter a number between 0 and {lastIndex}"; // Displaying the range of 0 to the last index

            // Displaying it to our label
            lblNumberOfLetters.Content = formatedString;
        }

        private void btnDisplayLetter_Click(object sender, RoutedEventArgs e)
        {
            string userWord = txtWord.Text;
            // Grabbing the word and parsing in one line
            int usersNumber = int.Parse(txtCharIndex.Text);
            char selectedChar = userWord[usersNumber];

       
            txtDisplayLetter.Text = selectedChar.ToString(); ;
            // btnDisplayLetter_Click
        }
    } 

}
