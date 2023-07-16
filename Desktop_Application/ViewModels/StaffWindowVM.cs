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
using System.Windows.Controls;

namespace Desktop_Application.ViewModels
{
    public partial class StaffWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string firstName = string.Empty;

        [ObservableProperty]
        public string lastName = string.Empty;

        [ObservableProperty]
        public string nicNo = string.Empty;

        [ObservableProperty]
        public string mathsGrade = string.Empty;

        [ObservableProperty]
        public string scienceGrade = string.Empty;

        [ObservableProperty]
        public string historyGrade = string.Empty;

        [ObservableProperty]
        public string ictGrade = string.Empty;

        [ObservableProperty]
        public string commerceGrade = string.Empty;

        [ObservableProperty]
        public ObservableCollection<Student> schoolStudents;


        // Calculate the GPA based on the grade values
        public double CalculateGPA(Student s)
        {
            return (Subject_GPA(s.MathsGrade) + Subject_GPA(s.ScienceGrade) + Subject_GPA(s.HistoryGrade) + Subject_GPA(s.IctGrade) + Subject_GPA(s.CommerceGrade)) / 5;
        }

        public double Subject_GPA(string grade)
        {
            switch (grade)
            {
                case "A+":
                    return 4.000;
                case "A":
                    return 4.000;
                case "A-":
                    return 3.700;
                case "B+":
                    return 3.300;
                case "B":
                    return 3.000;
                case "B-":
                    return 2.700;
                case "C+":
                    return 2.300;
                case "C":
                    return 2.000;
                case "C-":
                    return 1.700;
                case "F":
                    return 0.000;
                default:
                    return 0.000;
            }
        }


        public bool nicNoExists;
        [RelayCommand]
        public void InserPerson()
        {
            Student p = new Student()
            {
                FirstName = FirstName,
                LastName = LastName,
                NicNo = NicNo,
                MathsGrade = MathsGrade,
                ScienceGrade = ScienceGrade,
                HistoryGrade = HistoryGrade,
                IctGrade = IctGrade,
                CommerceGrade = CommerceGrade
            };

            p.GPA = CalculateGPA(p);

            using (var db = new DataBaseContext())
            {
                nicNoExists = db.Students.Any(item => item.NicNo == p.NicNo);
                if (!nicNoExists)
                {
                    db.Students.Add(p);
                    db.SaveChanges();
                }
                
            }

            LoadPerson();
        }



        private Student editedStudent;
        private EditStudentWindow editWindow;

        [RelayCommand]
        public void Edit(object parameter)
        {


            if (parameter is Student student)
            {
                editedStudent = student;
                editWindow = new EditStudentWindow(editedStudent);

                Window? staffWindow = Application.Current.Windows.OfType<StaffWindow>().FirstOrDefault();
                if (staffWindow != null)
                {
                    staffWindow.Visibility = Visibility.Hidden;
                }

                editWindow.ShowDialog();

                // After the edit window is closed, check if the student was modified
                if (editWindow.IsModified)
                {
                    // Update the student in the database and reload the students
                    using (var db = new DataBaseContext())
                    {
                        var originalStudent = db.Students.FirstOrDefault(s => s.Id == editedStudent.Id);
                        if (originalStudent != null)
                        {
                            // Update the properties of the original student with the modified values
                            originalStudent.FirstName = editedStudent.FirstName;
                            originalStudent.LastName = editedStudent.LastName;
                            originalStudent.NicNo = editedStudent.NicNo;
                            originalStudent.MathsGrade = editedStudent.MathsGrade;
                            originalStudent.ScienceGrade = editedStudent.ScienceGrade;
                            originalStudent.HistoryGrade = editedStudent.HistoryGrade;
                            originalStudent.IctGrade = editedStudent.IctGrade;
                            originalStudent.CommerceGrade = editedStudent.CommerceGrade;
                            originalStudent.GPA = CalculateGPA(originalStudent);

                            db.SaveChanges();
                        }
                    }
                }
                // Reload the students
                LoadPerson();
                if (staffWindow != null)
                {
                    staffWindow.Visibility = Visibility.Visible;
                }
            }

        }


        [RelayCommand]
        public void DeletePerson(Student student)
        {
            DeleteStudentWindow deleteWindow = new DeleteStudentWindow(student);
            deleteWindow.ShowDialog();

            if (student == null)
            {
                return;
            }
            else if (deleteWindow.IsConfirmDelete)
            {
                using (var db = new DataBaseContext())
                {
                    var originalPerson = db.Students.FirstOrDefault(p => p.Id == student.Id);
                    if (originalPerson != null)
                    {
                        db.Students.Remove(originalPerson);
                        db.SaveChanges();
                    }
                }
                SchoolStudents.Remove(student);
                LoadPerson();
            }
        }



        public void LoadPerson()
        {
            using (var db = new DataBaseContext())
            {
                var list = db.Students.OrderByDescending(p => p.GPA).ToList();
                SchoolStudents.Clear(); // Clear the collection
                foreach (var student in list)
                {
                    SchoolStudents.Add(student); // Add the loaded students
                }
            }
        }


        public StaffWindowVM()
        {
            SchoolStudents = new ObservableCollection<Student>(); // Initialize the collection
            LoadPerson();
        }

    }
}
