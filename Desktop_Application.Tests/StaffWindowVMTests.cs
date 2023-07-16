using Desktop_Application.Models;
using Desktop_Application.ViewModels;
using FluentAssertions;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Application.Tests
{
    public class StaffWindowVMTests
    {
        [Fact]
        public void CalculateGPA_Should_Return_CorrectGPA()
        {
            // Arrange
            var viewModel = new StaffWindowVM();
            var grade = "A";

            // Act
            var gpa = viewModel.Subject_GPA(grade);

            // Assert
            gpa.Should().Be(4.000); // Assert that the GPA is 4.000 for grade "A"
        }

        [Fact]
        public void Calculate_OverallGPA_Should_Return_CorrectValue()
        {
            var viewModel = new StaffWindowVM();
            var student = new Student()
            {
                FirstName = "John",
                LastName = "Doe",
                NicNo = "123456789",
                MathsGrade = "A",
                ScienceGrade = "A-",
                HistoryGrade = "C",
                IctGrade = "B",
                CommerceGrade = "C+"
            };

            // Calculate the expected overall GPA manually
            var expectedOverallGpa = (4.0 + 3.7 + 3.0 + 2.0 + 2.3) / 5.0;

            // Act
            var actualOverallGpa = viewModel.CalculateGPA(student);

            // Assert
            Assert.Equal(expectedOverallGpa, actualOverallGpa);
        }


        [Fact]
        public void InserPerson_Should_AddStudent_ToSchoolStudents()
        {
            // Arrange
            var viewModel = new StaffWindowVM()
            {
                FirstName = "John",
                LastName = "Doe",
                NicNo = "123456789",
                MathsGrade = "A",
                ScienceGrade = "B",
                HistoryGrade = "C",
                IctGrade = "B+",
                CommerceGrade = "A-"
            };

            var student = new Student()
            {
                FirstName = "John",
                LastName = "Doe",
                NicNo = "123456789",
                MathsGrade = "A",
                ScienceGrade = "B",
                HistoryGrade = "C",
                IctGrade = "B+",
                CommerceGrade = "A-"
            };

            // Act
            viewModel.InserPerson();

            // Assert
            var addedStudent = viewModel.SchoolStudents.FirstOrDefault(s =>
                s.FirstName == student.FirstName &&
                s.LastName == student.LastName &&
                s.NicNo == student.NicNo &&
                s.MathsGrade == student.MathsGrade &&
                s.ScienceGrade == student.ScienceGrade &&
                s.HistoryGrade == student.HistoryGrade &&
                s.IctGrade == student.IctGrade &&
                s.CommerceGrade == student.CommerceGrade
            );

            addedStudent.Should().NotBeNull();
            viewModel.SchoolStudents.Should().Contain(addedStudent);

            //addedStudent.Should().NotBeNull(); 
            // Assert that the student is added to SchoolStudents collection

            viewModel.DeletePerson(addedStudent);
        }



        [Fact]
        public void DeletePerson_Should_Remove_Student_From_SchoolStudents()
        {
            // Arrange
            var viewModel = new StaffWindowVM();
            var student = new Student()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                NicNo = "123456789",
                MathsGrade = "A",
                ScienceGrade = "B",
                HistoryGrade = "C",
                IctGrade = "B+",
                CommerceGrade = "A-"
            };
            viewModel.SchoolStudents.Add(student);

            // Act
            viewModel.DeletePerson(student);

            // Assert
            // Assert that the student is removed from SchoolStudents collection
            viewModel.SchoolStudents.Should().NotContain(student);
        }

        // Add more tests for other methods in the StaffWindowVM class as needed
    }
}
