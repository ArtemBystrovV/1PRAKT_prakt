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
using _1PRAKT.stroikontorkaDataSetTableAdapters;

namespace _1PRAKT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            // перенаправление на страницу Worker
            Page1 workerPage = new Page1();
            this.Content = workerPage;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            // перенаправление на страницу Postavshik
            Page2 postavshikPage = new Page2();
            this.Content = postavshikPage;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            // перенаправление на страницу Materials
            Page3 materialsPage = new Page3();
            this.Content = materialsPage;
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            // перенаправление на страницу Bulding_odject
            Page4 buldingOdjectPage = new Page4();
            this.Content = buldingOdjectPage;
        }

      

    }
}
