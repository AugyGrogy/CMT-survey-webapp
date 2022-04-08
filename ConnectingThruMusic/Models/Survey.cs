using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers
{
    public class Survey
    {

        public int SurveyID { get; set; }

        public string SurveyName { get; set; }

        public string SurveyType { get; set; }

        public List<Questions> Questions { get; set; }

        public List<Answers> Answers { get; set; }

    }
}
