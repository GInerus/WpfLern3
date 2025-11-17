using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLern3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonRegistration_Click(object sender, RoutedEventArgs e)
        {
            string enteredLogin = textBoxLogin.Text.Trim();
            string enteredPasswordFirst = passwordBoxFirst.Password.Trim();
            string enteredPasswordSecond = passwordBoxSecond.Password.Trim();
            string enteredEmail = textBoxEmail.Text.Trim().ToLower();

            if (enteredLogin.Length < 4)
            {
                textBoxLogin.ToolTip = "Логин не может быть меньше 4 символов";
                textBoxLogin.Background = Brushes.IndianRed;
            }
            else if (enteredPasswordFirst.Length < 8)
            {
                passwordBoxFirst.ToolTip = "Пароль не может быть меньше 8 символов";
                passwordBoxFirst.Background = Brushes.IndianRed;
            }
            else if (enteredPasswordFirst != enteredPasswordSecond)
            {
                passwordBoxSecond.ToolTip = "Пороли не савподают";
                passwordBoxSecond.Background = Brushes.IndianRed;
            }
            else if (enteredEmail.Length < 6 || !enteredEmail.Contains('@') || !enteredEmail.Contains('.'))
            {
                textBoxEmail.ToolTip = "Поле заполнено неверно";
                textBoxEmail.Background = Brushes.IndianRed;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passwordBoxFirst.ToolTip = "";
                passwordBoxFirst.Background = Brushes.Transparent;
                passwordBoxSecond.ToolTip = "";
                passwordBoxSecond.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Заебись получается!!!");
            }
        }
    }
}