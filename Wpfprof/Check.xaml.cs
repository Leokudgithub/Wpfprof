using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
   /// Логика взаимодействия для check.xaml
   /// </summary>
    public partial class Check : Window
    {
        public Check()
       {
            InitializeComponent();
            LoadCheck();
       }

       private void LoadCheck()
       {
            var items = new List<string>();
            var page4 = new Page4();
            if (page4.GetParameters1() != null)
            {
                items.Add(page4.GetParameters1());

            }
            else if (page4.GetParameters2() != null)
            {
                items.Add(page4.GetParameters2());
            }
            else if (page4.GetParameters3() != null)
            {
                items.Add(page4.GetParameters3());
            }
            else if (page4.GetParameters5() != null)
            {
                items.Add(page4.GetParameters5());
            }
            ItemsCheck.ItemsSource = items;

       }
    }
}