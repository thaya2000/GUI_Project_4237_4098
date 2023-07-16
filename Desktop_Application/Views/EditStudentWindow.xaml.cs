using Desktop_Application.Models;
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

namespace Desktop_Application.Views
{
  
    public partial class EditStudentWindow : Window
    {
        public EditStudentWindow(Student student)
        {
            InitializeComponent();
            DataContext = student;
        }

        public bool IsModified { get; private set; }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            IsModified = true;
            Close();
        }


        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
