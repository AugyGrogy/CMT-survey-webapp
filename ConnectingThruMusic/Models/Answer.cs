using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StaffMembers
{
	public class Answer
	{
		public int answerID { get; set; }
		public int questionID { get; set; }
		public int answerText { get; set; }
		public int questionType { get; set; }
	}
}