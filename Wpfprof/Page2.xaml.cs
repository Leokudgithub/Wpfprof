using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Wpfprof
{
    public partial class Page2 : Page
    {
        // Список для хранения состояния столов (true - свободен, false - занят)
        private List<bool> tableStates = new List<bool> { true, true, true, true, true, true }; // Все столы свободны

        public Page2()
        {
            InitializeComponent();
            UpdateTableButtons(); // Обновляем состояние кнопок столов
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); // Возврат на предыдущую страницу
        }

        private void Menu1(object sender, RoutedEventArgs e)
        {
            // Здесь можно добавить логику для обработки нажатия на стол
            // Например, можно сохранить состояние стола как занятый
            Button clickedButton = sender as Button;
            int tableIndex = int.Parse(clickedButton.Content.ToString()) - 1; // Получаем индекс стола
            tableStates[tableIndex] = false; // Устанавливаем стол как занятый
            UpdateTableButtons(); // Обновляем состояние кнопок столов
            NavigationService.Navigate(new Page3()); // Переход на страницу с меню
        }

        private void UpdateTableButtons()
        {
            // Обновляем цвет кнопок в зависимости от состояния столов
            Button[] tableButtons = { TableButton1, TableButton2, TableButton3, TableButton4, TableButton5, TableButton6 };
            for (int i = 0; i < tableButtons.Length; i++)
            {
                if (tableStates[i])
                {
                    tableButtons[i].Background = Brushes.Green; // Свободный стол
                }
                else
                {
                    tableButtons[i].Background = Brushes.Red; // Занятый стол
                }
            }
        }
    }
}