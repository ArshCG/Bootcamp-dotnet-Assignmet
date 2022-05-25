using System;
using System.Collections.Generic;

namespace EmployeeWebApp.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpGender { get; set; }
        public string EmpPos { get; set; }
        public string EmpProject { get; set; }
    }
}
