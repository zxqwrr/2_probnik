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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void NavigateToPage(string navigate)
        {
            switch (navigate)
            {
                case "Page1":
                    MainFrame.Navigate(new Page1());
                break;
                case "Page2":
                    MainFrame.Navigate(new Page2());
                    break;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage("Page1");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage("Page2");
        }
    }
}
