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

namespace Task_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> itemsToAdd = new List<string>
            {
                "9:00 Classes Start",
                "10:25 Break",
                "10:35 Second Class Start",
                "12:00 End of classes"
            };

            foreach (string item in itemsToAdd)
            {
                MainListBox.Items.Add(item);
            }
        }
    }
}
