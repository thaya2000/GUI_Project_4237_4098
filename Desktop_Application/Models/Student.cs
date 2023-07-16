using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Application.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        //public string RegNo { get; set; }
        
        public string? NicNo { get; set; }
        public required string MathsGrade { get; set; }
        public required string ScienceGrade { get; set; }
        public required string HistoryGrade { get; set; }
        public required string IctGrade { get; set; }
        public required string CommerceGrade { get; set; }
        public double GPA { get; set; }
    }

}
