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

namespace kedrolivanskaya
{
    /// <summary>
    /// Логика взаимодействия для Patern_Control.xaml
    /// </summary>
    public partial class Patern_Control : UserControl
    {
        Incom i; 
        public  Patern_Control(Incom i)
        {
            InitializeComponent();
            this.i = i;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            label_price.Content = i.Price;
            label_title.Content = i.Title;
            if ( i is Food)
            {
                // Сюда вставим код для картики
            }
        }
    }
}
