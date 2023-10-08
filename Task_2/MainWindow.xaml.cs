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

namespace Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GenerateNewCode();
        }

        private void ButtonIsClicked(object sender, RoutedEventArgs e)
        {
            if (MainTextBox.Text.Length > 45) MainTextBox.Text = ">";
            Button button= (Button)sender;
            MainTextBox.Text += button.Content.ToString();
        }

        private void CButtonIsClicked(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text= ">";
        }

        private void OkButtonIsClicked(object sender, RoutedEventArgs e)
        {
           
            if (">" +this.Title == MainTextBox.Text)
            {
                MainTextBox.Text = ">";
                MessageBox.Show("Correct!");
                GenerateNewCode();
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
        }

        private void GenerateNewCode()
        {
            Random random= new Random();
            this.Title = random.Next(1000000, 9999999).ToString();
        }
    }
}
