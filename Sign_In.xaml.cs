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

namespace Phototronix_app_version1
{
    /// <summary>
    /// Логика взаимодействия для Sign_In.xaml
    /// </summary>
    public partial class Sign_In : Window
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void passwordCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.PasswordChar = '•';
        }
        private void passwordCheck_Checked(object sender, RoutedEventArgs e)
        {
            passwordBox.PasswordChar = (char)0;
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
