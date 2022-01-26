﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StaffMembers
{
    public class Question
    {
		public int questionID { get; set; }
		public int questionType { get; set; }
		public int effectiveDate { get; set; }
		public int expirationDate { get; set; }
		public string questionText { get; set; }
	}
}
