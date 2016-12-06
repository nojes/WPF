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

namespace _01_UserControl
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public string password { get; set; }

        public LoginControl()
        {
            InitializeComponent();

            textBox.Text = "";
        }

        public int MyProperty { get; set; }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            password = textBox.Text;

            if (password.Length < 7) {
                canvas.Background = new SolidColorBrush(Colors.Red);
                e.Handled = true;
            }
            else if (password.Length < 8) {
                canvas.Background = new SolidColorBrush(Colors.Orange);
                e.Handled = true;
            }
            else {
                canvas.Background = new SolidColorBrush(Colors.GreenYellow);
                e.Handled = true;
            }
        }
    }
}
