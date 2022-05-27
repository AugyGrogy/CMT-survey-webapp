using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers
{
   public class SurveyQuestions
    {
        public int SurveyID { get; set; }
        public Survey Survey { get; set; }
        public int QuestionId { get; set; }
        public Questions Questions { get; set; }

    }
}
