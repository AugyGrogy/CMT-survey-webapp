using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StaffMembers
{
    public partial class Staff
    {
        public int StaffId { get; set; }
        public string StaffFname { get; set; }
        public string StaffLname { get; set; }
        public string StaffEmail { get; set; }
        public string StaffRole { get; set; }
        public string StaffPassword { get; set; }
    }
}
