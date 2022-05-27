using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers
{
    public class InstructorSurveyResponses
    {
        public int SurveyID { get; set; }
        public string SurveyName { get; set; }
        public string QuestionText { get; set; }
        public string QuestionResponse { get; set; }
        public string Email { get; set; }
        public DateTime ResponseDate { get; set; }

    }
}
