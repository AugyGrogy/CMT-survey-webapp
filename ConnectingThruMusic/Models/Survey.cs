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

        public IList<SurveyQuestions> SurveyQuestions { get; set; }

    }
}
