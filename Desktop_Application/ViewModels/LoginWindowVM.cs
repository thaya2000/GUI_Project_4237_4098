using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_Application.Data;
using Desktop_Application.Models;
using Desktop_Application.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Desktop_Application.ViewModels
{
    public partial class LoginWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string userName;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        ObservableCollection<User> people;

        public bool successlogin;

        [RelayCommand]
        public void LogInUser()
        {
            User u = new User()
            {
                Username = UserName,
                Password = Password,
            };

            using (var db = new DataBaseContext())
            {
                successlogin = false;
                var staff = db.Users;
                foreach (var Item in staff)
                {
                    if (Item.Username == UserName && Item.Password == Password && Item.IsAdmin == true)
                    {

                        successlogin = true;
                        AdminWindow adminWindow = new AdminWindow();
                        adminWindow.Show();

                        Window? loginWindow = Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault();
                        if (loginWindow != null)
                        {
                            loginWindow.Close();
                        }
                        //MessageBox.Show("You successfully login as Admin");
                        return;
                    }
                    else if (Item.Username == UserName && Item.Password == Password && Item.IsAdmin == false)
                    {
                        StaffWindow staffWindow = new StaffWindow();
                        staffWindow.Show();
                        //MessageBox.Show("You successfully login as Staff");
                        successlogin = true;

                        Window? loginWindow = Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault();
                        if (loginWindow != null)
                        {
                            loginWindow.Close();
                        }
                        return;
                    }
                    
                }
                //if (!successlogin)
                //{
                //    MessageBox.Show("Invalid username and Password");
                //}
            }
        }

        public bool usernameExists;
        [RelayCommand]
        public void InsertUser()
        {
            User u = new User()
            {
                Username = UserName,
                Password = Password,
                IsAdmin = false
            };

            using (var db = new DataBaseContext())
            {
                usernameExists = db.Users.Any(item => item.Username == u.Username);

                if (!usernameExists)
                {
                    db.Users.Add(u);
                    db.SaveChanges();
                }
                
            }
        }
    }
}
