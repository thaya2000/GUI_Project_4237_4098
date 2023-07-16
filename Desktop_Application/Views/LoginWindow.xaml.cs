using Desktop_Application.ViewModels;
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

namespace Desktop_Application.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginWindowVM();
        }

        private void textUsername_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && txtUsername.Text.Length > 0)
            {
                textUsername.Visibility = Visibility.Collapsed;
            }
            else
            {
                textUsername.Visibility = Visibility.Visible;
            }
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

       

        private void ShowText_Block_For_Five_Seconds(TextBlock textBlock)
        {
            textBlock.Visibility = Visibility.Visible;

            // Create a timer with a 5-second interval
            System.Timers.Timer timer = new System.Timers.Timer(5000);
            timer.AutoReset = false; // Set to false to run the timer only once

            // Timer elapsed event handler
            timer.Elapsed += (sender, e) =>
            {
                // Hide the text block after 5 seconds
                Dispatcher.Invoke(() =>
                {
                    textBlock.Visibility = Visibility.Collapsed;
                });

                // Dispose the timer
                timer.Dispose();
            };

            // Start the timer
            timer.Start();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginWindowVM viewModel)
            {
                viewModel.LogInUserCommand.Execute(this);

                txtUsername.Clear();
                txtPassword.Clear();


                if (!viewModel.successlogin)
                {
                    ShowText_Block_For_Five_Seconds(tb_usernam_password_invalid);
                }
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
