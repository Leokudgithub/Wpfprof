using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); // Возврат на предыдущую страницу
        }
        public void check_click(object sender, RoutedEventArgs e)
        {
            // Создаем экземпляр нового окна
            Check check = new Check();
            // Открываем новое окно
            check.Show();
            
        }
        public void click1(object sender, RoutedEventArgs e)
        {
            
                // Создаем новую строку с названием кнопки и параметрами
                string newItem = ((Button)sender).Content + " | " + GetParameters1();
            
                // Добавляем строку в ListBox
                var product = new Product(((Button)sender).Content.ToString(), GetParameters1());
                ItemsListBox.Items.Add(newItem);
                
        }
        public string GetParameters1()
        {
            // Здесь вы можете добавить любую логику для получения параметров
            int cash = 500;
            string cash1 = cash.ToString();
            return cash1; // Замените на реальные параметры
        }
        public void click2(object sender, RoutedEventArgs e)
        {
            // Создаем новую строку с названием кнопки и параметрами
            string newItem = ((Button)sender).Content + " | " + GetParameters2();

            // Добавляем строку в ListBox
            ItemsListBox.Items.Add(newItem);
        }
        public string GetParameters2()
        {
            // Здесь вы можете добавить любую логику для получения параметров
            int cash = 600;
            string cash1 = cash.ToString();
            return cash1; // Замените на реальные параметры
        }
        public void click3(object sender, RoutedEventArgs e)
        {
            // Создаем новую строку с названием кнопки и параметрами
            string newItem = ((Button)sender).Content + " | " + GetParameters3();

            // Добавляем строку в ListBox
            ItemsListBox.Items.Add(newItem);
        }
        public string GetParameters3()
        {
            // Здесь вы можете добавить любую логику для получения параметров
            int cash = 650;
            string cash1 = cash.ToString();
            return cash1; // Замените на реальные параметры
        }
        public void click4(object sender, RoutedEventArgs e)
        {
            // Создаем новую строку с названием кнопки и параметрами
            string newItem = ((Button)sender).Content + " | " + GetParameters4();

            // Добавляем строку в ListBox
            ItemsListBox.Items.Add(newItem);
        }
        public string GetParameters4()
        {
            // Здесь вы можете добавить любую логику для получения параметров
            int cash = 470;
            string cash1 = cash.ToString();
            return cash1; // Замените на реальные параметры
        }
        public void click5(object sender, RoutedEventArgs e)
        {
            // Создаем новую строку с названием кнопки и параметрами
            string newItem = ((Button)sender).Content + " | " + GetParameters5();

            // Добавляем строку в ListBox
            ItemsListBox.Items.Add(newItem);
        }
        public string GetParameters5()
        {
            // Здесь вы можете добавить любую логику для получения параметров
            int cash = 520;
            string cash1 = cash.ToString();
            return cash1; // Замените на реальные параметры
        }
    }
}
