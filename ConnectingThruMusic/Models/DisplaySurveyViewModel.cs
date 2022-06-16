using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers.Models
{
   public class DisplaySurveyViewModel
    {
        public IEnumerable<Questions> Questions { get; set; }
        public IEnumerable<Survey> Survey { get; set; }
        public IEnumerable<SurveyQuestions> SurveyQuestions { get; set; }

    }
}
