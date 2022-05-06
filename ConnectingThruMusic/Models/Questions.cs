using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StaffMembers
{
    public partial class Questions
    {
        [Key]
        public int QuestionId { get; set; }
        [Required(ErrorMessage = "Please enter a question")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string QuestionText { get; set; }
        [Required(ErrorMessage = "Please select a question type")]
        public string QuestionType { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string AnswerE { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public IList<SurveyQuestions> SurveyQuestions { get; set; }

    }
}