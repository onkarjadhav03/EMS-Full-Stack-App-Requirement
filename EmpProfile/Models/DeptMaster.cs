using System;
using System.Collections.Generic;

namespace EmployeeProfile.Models
{
    public partial class DeptMaster
    {
        public DeptMaster()
        {
            EmpProfiles = new HashSet<EmpProfile>();
        }

        public int DeptCode { get; set; }
        public string DeptName { get; set; } = null!;

        public virtual ICollection<EmpProfile> EmpProfiles { get; set; }
    }
}
