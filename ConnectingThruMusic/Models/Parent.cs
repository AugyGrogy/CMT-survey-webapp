﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StaffMembers
{
    public partial class Parent
    {
        public int ParentId { get; set; }
        public int GroupId { get; set; }
        public int QuarterId { get; set; }
        public int TimeframeId { get; set; }
    }
}
