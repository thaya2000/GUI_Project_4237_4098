using Desktop_Application.ViewModels;
using Desktop_Application.Views;
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

namespace Desktop_Application.Views
{
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow()
        {
            InitializeComponent();
            DataContext = new StaffWindowVM();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            var staffWindow = new StaffWindow();
            staffWindow.Show();
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void textFirstNme_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtFirstNme.Focus();
        }

        private void txtFirstNme_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstNme.Text) && txtFirstNme.Text.Length > 0)
            {
                textFirstNme.Visibility = Visibility.Collapsed;
            }
            else
            {
                textFirstNme.Visibility = Visibility.Visible;
            }
        }

        private void textLastName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtLastName.Focus();
        }

        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLastName.Text) && txtLastName.Text.Length > 0)
            {
                textLastName.Visibility = Visibility.Collapsed;
            }
            else
            {
                textLastName.Visibility = Visibility.Visible;
            }
        }

        private void textNicNo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtNicNo.Focus();
        }

        private void txtNicNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNicNo.Text) && txtNicNo.Text.Length > 0)
            {
                textNicNo.Visibility = Visibility.Collapsed;
            }
            else
            {
                textNicNo.Visibility = Visibility.Visible;
            }
        }

        private void textMaths_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtMaths.Focus();
        }

        private void txtMaths_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaths.Text) && txtMaths.Text.Length > 0)
            {
                textMaths.Visibility = Visibility.Collapsed;
            }
            else
            {
                textMaths.Visibility = Visibility.Visible;
            }
        }

        private void textScience_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtScience.Focus();
        }

        private void txtScience_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScience.Text) && txtScience.Text.Length > 0)
            {
                textScience.Visibility = Visibility.Collapsed;
            }
            else
            {
                textScience.Visibility = Visibility.Visible;
            }
        }

        private void textHistory_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtHistory.Focus();
        }

        private void txtHistory_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScience.Text) && txtScience.Text.Length > 0)
            {
                textHistory.Visibility = Visibility.Collapsed;
            }
            else
            {
                textHistory.Visibility = Visibility.Visible;
            }
        }

        private void textIct_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtIct.Focus();
        }

        private void txtIct_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIct.Text) && txtIct.Text.Length > 0)
            {
                textIct.Visibility = Visibility.Collapsed;
            }
            else
            {
                textIct.Visibility = Visibility.Visible;
            }
        }

        private void textCommerce_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtCommerce.Focus();
        }

        private void txtCommerce_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCommerce.Text) && txtCommerce.Text.Length > 0)
            {
                textCommerce.Visibility = Visibility.Collapsed;
            }
            else
            {
                textCommerce.Visibility = Visibility.Visible;
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


        private void AddStudent_Create_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is StaffWindowVM viewModel)
            {
                viewModel.InserPersonCommand.Execute(this);

                if (!viewModel.nicNoExists)
                {
                    var staffWindow = new StaffWindow();
                    staffWindow.Show();
                    this.Close();
                }
                else
                {
                    ShowText_Block_For_Five_Seconds(tb_nic_exist);
                }
            }

            

            
        }
    }
}
