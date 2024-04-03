using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).ListBox.Items.Remove(((MainWindow)Application.Current.MainWindow).ListBox.SelectedItem);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            string Edit = EditTextBox.Text;
            ((MainWindow)Application.Current.MainWindow).ListBox.Items.Remove(((MainWindow)Application.Current.MainWindow).ListBox.SelectedItem);
            if (!string.IsNullOrEmpty(Edit))
            {
                ((MainWindow)Application.Current.MainWindow).ListBox.Items.Add(Edit);
                EditTextBox.Clear();
            }
        }
    }
}
