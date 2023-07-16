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

namespace Desktop_Application.CustomControl
{
    /// <summary>
    /// Interaction logic for BindablePasswordBox.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Password.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(BindablePasswordBox), new PropertyMetadata(string.Empty));

        public BindablePasswordBox()
        {
            InitializeComponent();
        }


        public event RoutedEventHandler PasswordChanged
        {
            add { AddHandler(PasswordChangedEvent, value); }
            remove { RemoveHandler(PasswordChangedEvent, value); }
        }

        public static readonly RoutedEvent PasswordChangedEvent =
            EventManager.RegisterRoutedEvent(
                "PasswordChanged",
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(BindablePasswordBox)
            );

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = passwordBox.Password;
            RaiseEvent(new RoutedEventArgs(PasswordChangedEvent));
        }
        //private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        //{
        //    Password = passwordBox.Password;
        //}

        public new void Focus()
        {
            base.Focus();
            passwordBox.Focus();
        }

        public void Clear()
        {
            passwordBox.Clear();
            Password = string.Empty;
        }

    }
}
