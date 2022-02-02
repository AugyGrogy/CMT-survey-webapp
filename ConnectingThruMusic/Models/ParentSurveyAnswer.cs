using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StaffMembers
{
    public partial class ParentSurveyAnswer
    {
        public int QuestionId { get; set; }
        public int ParentId { get; set; }
        public int AnswerId { get; set; }
    }
}
