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

namespace Wpfprof
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {

        public Page3()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); // Возврат на предыдущую страницу
        }
        private void Bar_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page5());
        }
        private void Syp_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());
        }
        private void Salati_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page6());
        }
        private void Pasty_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page7());
        }
        private void Dobavy_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page8());
        }
    }
}
