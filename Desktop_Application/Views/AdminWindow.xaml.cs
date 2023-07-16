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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Desktop_Application.Views
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
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
            //textPassword.Visibility = Visibility.Collapsed;

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

        //private void Admin_close_Click(object sender, RoutedEventArgs e)
        //{
        //    LoginWindow loginWindow = new LoginWindow();
        //    loginWindow.Show();
        //    this.Close();
        //}

        //private void ShowTextBlockForSeconds(TextBlock textBlock, int seconds)
        //{
        //    textBlock.Visibility = Visibility.Visible;

        //    DispatcherTimer timer = new DispatcherTimer();
        //    timer.Interval = TimeSpan.FromSeconds(seconds);
        //    timer.Tick += (sender, e) =>
        //    {
        //        timer.Stop();
        //        textBlock.Visibility = Visibility.Collapsed;
        //    };

        //    timer.Start();
        //}

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



        private void create_account_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginWindowVM viewModel)
            {
                viewModel.InsertUserCommand.Execute(this);

                txtUsername.Clear();
                txtPassword.Clear();


                if (viewModel.usernameExists)
                {
                    ShowText_Block_For_Five_Seconds(tb_user_exist);
                }
                else
                {
                    ShowText_Block_For_Five_Seconds(tb_user_created);

                }
            }
        }


        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private void signoutadminbutton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
