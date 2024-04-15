using _1PRAKT.stroikontorkaDataSetTableAdapters;
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

namespace _1PRAKT
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        workersTableAdapter Workers = new workersTableAdapter();
        public Page1()
        {
            InitializeComponent();
            WorkerDataGrid.ItemsSource = Workers.GetData();   
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Переходим на первичную страницу
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window currentWindow = Window.GetWindow(this);
            currentWindow.Close();
        }

        
    }
}
