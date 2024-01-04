using System;
using System.Collections.Generic;

namespace EmployeeProfile.Models
{
    public partial class EmpProfile
    {
        public int EmpCode { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? EmpName { get; set; }
        public string? Email { get; set; }
        public int? DeptCode { get; set; }

        public virtual DeptMaster? DeptCodeNavigation { get; set; }
    }
}
