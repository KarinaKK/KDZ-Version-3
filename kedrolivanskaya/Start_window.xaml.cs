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
using System.Windows.Shapes;

namespace kedrolivanskaya
{
    /// <summary>
    /// Логика взаимодействия для Start_window.xaml
    /// </summary>
    public partial class Start_window : Page
    {
        public Start_window(MainWindow m)
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Repository r = new Repository();
            foreach (var item in Repository.IncomList)

            {
                if( item.Type)
                {
                    Income_Stack.Children.Add(new Patern_Control(item));
                }
                else
                {
                   Expense_Stack.Children.Add(new Patern_Control(item));
                }
            }
        }
    }
}
