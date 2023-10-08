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

namespace Task_3
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

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if(textBox.Text.Length > 11 ) {
                textBox.Text = "0";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double f_00 = Convert.ToDouble(Button1.Text);
                double f_01 = Convert.ToDouble(Button2.Text);
                double f_02 = Convert.ToDouble(Button3.Text);
                double f_10 = Convert.ToDouble(Button4.Text);
                double f_11 = Convert.ToDouble(Button5.Text);
                double f_12 = Convert.ToDouble(Button6.Text);
                double f_20 = Convert.ToDouble(Button7.Text);
                double f_21 = Convert.ToDouble(Button8.Text);
                double f_22 = Convert.ToDouble(Button9.Text);

                double determinant =
                     f_00 * (f_11 * f_22 - f_12 * f_21) -
                     f_01 * (f_10 * f_22 - f_12 * f_20) +
                     f_02 * (f_10 * f_21 - f_11 * f_20);
                determinant = Math.Round(determinant, 2);
                LabelResult.Content = determinant.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
