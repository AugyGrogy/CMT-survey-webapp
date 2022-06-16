using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers.Models
{
   public class DisplaySurveyViewModel
    {
        public int SurveyID { get; set; }
        public string SurveyName { get; set; }
        public string SurveyType { get; set; }
        public List<int> SelectedQuestionId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string AnswerE { get; set; }
    }
}
