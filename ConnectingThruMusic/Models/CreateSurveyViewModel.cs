using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers.Models
{
    public class CreateSurveyViewModel
    {

        public string SurveyName { get; set; }
        public string SurveyType { get; set; }
        public List <Questions> Questions { get; set; }

}
}
