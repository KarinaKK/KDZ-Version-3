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
    /// Логика взаимодействия для Page_Avtorization.xaml
    /// </summary>
    public partial class Page_Avtorization : Page
    {
        MainWindow m;
        public Page_Avtorization(MainWindow m)
        {
            InitializeComponent();
            this.m = m;
        }

        
        private void log_in_click(object sender, RoutedEventArgs e)
        {
            m.main_frame.Content = new Start_window(m);
        }

        private void Sign_up_click(object sender, RoutedEventArgs e)
        {
            Sig_up_window p = new Sig_up_window();
            p.Show();
        }
    }
}
