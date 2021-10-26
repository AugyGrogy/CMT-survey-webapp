using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Models
{
    public class Question
    {
		public int Id { get; set; }
		public string QuestionText { get; set; }
		public int QuestionType { get; set; }
		public string AnswerA { get; set; }
		public string AnswerB { get; set; }
		public string AnswerC { get; set; }
		public string AnswerD { get; set; }
		public string AnswerE { get; set; }
	}
}
