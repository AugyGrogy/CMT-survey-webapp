using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
 //       public List<int?> SelectedQuestionId { get; set; }


        public class SurveyResponseViewModel
        {
            public int SurveyID { get; set; }

            public string SurveyName { get; set; }

            public string SurveyType { get; set; }

            public IList<SurveyQuestions> SurveyQuestions { get; set; }


            public Task<SurveyResponseViewModel> ToSurveyResponseViewModelAsync(int? id)
            {
                return null;
            }
        }
    }
}
