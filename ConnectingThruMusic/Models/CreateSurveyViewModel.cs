using System.Collections.Generic;
using System.Linq;

namespace StaffMembers.Models
{
    public class CreateSurveyViewModel
    {

        public string SurveyName { get; set; }
        public string SurveyType { get; set; }
        public List <Questions> Questions { get; set; }
        public List<int> SelectedQuestionId { get; set; }

    
        public Survey ToEntity() {
            return new Survey() {
                SurveyName = this.SurveyName,
                SurveyType = this.SurveyType,
                SurveyQuestions = this.SelectedQuestionId.Select(x => new SurveyQuestions() {
                    QuestionId = x
                }).ToList()
            };
        }
    }
}
