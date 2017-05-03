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
    /// Логика взаимодействия для First_Page.xaml
    /// </summary>
    public partial class First_Page : Page
    {
        public First_Page(MainWindow m )
        {
            InitializeComponent();
            _m = m;
        }
        MainWindow _m;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            _m.main_frame.Content = new Page_Avtorization();

        }
    }
}
