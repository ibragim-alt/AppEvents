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

namespace AppEvents
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var listEvents = Helper.GetContext().Events.ToList();
            CmbEvents.ItemsSource = listEvents;
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbLogin.Text) && !string.IsNullOrEmpty(PwbPassword.Password))
            {
                try
                {
                    if (TbLogin.Text == Helper.GetContext().Staff.FirstOrDefault(x => x.Login.Contains(TbLogin.Text)).Login
                        && PwbPassword.Password == Helper.GetContext().Staff.FirstOrDefault(x => x.Password.Contains(PwbPassword.Password)).Password)
                    {
                        MessageBox.Show("Авторизация успешна", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Авторизация не успешна. Не верны логин или пароль ", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Авторизация не успешна. Не верны логин или пароль ", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
               MessageBox.Show("Авторизация не успешна. Не верны логин или пароль ", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void BtnNewMessage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPopMessage_Click(object sender, RoutedEventArgs e)
        {
            PopAppeals popAppeals = new PopAppeals();
            popAppeals.Show();
        }

        private void CmbEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
