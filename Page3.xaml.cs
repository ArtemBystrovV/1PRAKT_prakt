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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1PRAKT
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        MATERIALSTableAdapter MATERIALS = new MATERIALSTableAdapter();
        public Page3()
        {
            InitializeComponent();
            MATERIALSDataGrid.ItemsSource = MATERIALS.GetData();
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
