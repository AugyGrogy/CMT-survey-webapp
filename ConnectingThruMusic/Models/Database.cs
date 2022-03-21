using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StaffMembers.Models
{
    public class Database
    {
        public static List<Staff> GetStaff()
        {
            List<Staff> staffs = new List<Staff>
            {
                new Staff
                {
                    Name = "Mike Bruce",
                    Email = "MikeBruce@gmail.com",
                    Phone = "(904) 430-2645",
                    Years = "Mike Bruce have been working in this company for about 6 years.",
                    Bio = "Senior Project Manager"

                },


                 new Staff
                {
                    Name = "Tom Philp",
                    Email = "TomPhilp@gmail.com",
                    Phone = "(904) 4760-2845",
                    Years = "Tom Philp have been working in this company for about 2 years.",
                    Bio = "Field Officer"

                },

                  new Staff
                {
                    Name = "Robert dan",
                    Email = "Robertdan@gmail.com",
                    Phone = "(904) 491-2638",
                    Years = "Robert dan have been working in this company for about 9 years.",
                    Bio = "Manager"

                },


                   new Staff
                {
                    Name = "Mac steven",
                    Email = "Macsteven@gmail.com",
                    Phone = "(904) 210-2905",
                    Years = "Mac steven have been working in this company for about 3 years.",
                    Bio = "Assistant"

                },



                    new Staff
                {
                    Name = "David Tanner",
                    Email = "DavidTanner@gmail.com",
                    Phone = "(904) 130-2695",
                    Years = "Mike Bruce have been working in this company for about 10 years.",
                    Bio = "Senior Advisor"

                }
            };
            return staffs;
        }



        public static List<SurveyResults> GetResults()
        {
            List<SurveyResults> results = new List<SurveyResults>
            {
                new SurveyResults
                {
                   QuestionID = 1,
                   type = "mc",
                   instructorID = 1,
                   answerID = 1,
                   answer = "A",
                   groupID = 1,
                   quarterID = 1
                },

                new SurveyResults
                {
                   QuestionID = 1,
                   type = "mc",
                   instructorID = 2,
                   answerID = 1,
                   answer = "B",
                   groupID = 1,
                   quarterID = 1
                },

                new SurveyResults
                {
                   QuestionID = 1,
                   type = "mc",
                   instructorID = 3,
                   answerID = 1,
                   answer = "C",
                   groupID = 1,
                   quarterID = 1
                },

                new SurveyResults
                {
                   QuestionID = 1,
                   type = "mc",
                   instructorID = 4,
                   answerID = 1,
                   answer = "D",
                   groupID = 1,
                   quarterID = 1
                },

                new SurveyResults
                {
                   QuestionID = 1,
                   type = "mc",
                   instructorID = 5,
                   answerID = 1,
                   answer = "A",
                   groupID = 1,
                   quarterID = 1
                },

                new SurveyResults
                {
                   QuestionID = 1,
                   type = "mc",
                   instructorID = 6,
                   answerID = 1,
                   answer = "A",
                   groupID = 1,
                   quarterID = 1
                },

                new SurveyResults
                {
                   QuestionID = 1,
                   type = "mc",
                   instructorID = 7,
                   answerID = 1,
                   answer = "A",
                   groupID = 1,
                   quarterID = 1
                },

                new SurveyResults
                {
                   QuestionID = 1,
                   type = "mc",
                   instructorID = 8,
                   answerID = 1,
                   answer = "C",
                   groupID = 1,
                   quarterID = 1
                },
                //parents
                new SurveyResults
                {
                   QuestionID = 2,
                   type = "mc",
                   parentID = 1,
                   answerID = 2,
                   answer = "A",
                   groupID = 1,
                   quarterID = 1
                },
                new SurveyResults
                {
                   QuestionID = 2,
                   type = "mc",
                   parentID = 2,
                   answerID = 2,
                   answer = "B",
                   groupID = 1,
                   quarterID = 1
                },
                new SurveyResults
                {
                   QuestionID = 2,
                   type = "mc",
                   parentID = 3,
                   answerID = 2,
                   answer = "C",
                   groupID = 1,
                   quarterID = 1
                },
                new SurveyResults
                {
                   QuestionID = 2,
                   type = "mc",
                   parentID = 4,
                   answerID = 2,
                   answer = "D",
                   groupID = 1,
                   quarterID = 1
                },
                new SurveyResults
                {
                   QuestionID = 2,
                   type = "mc",
                   parentID = 5,
                   answerID = 2,
                   answer = "B",
                   groupID = 1,
                   quarterID = 1
                },
                new SurveyResults
                {
                   QuestionID = 2,
                   type = "mc",
                   parentID = 6,
                   answerID = 2,
                   answer = "B",
                   groupID = 1,
                   quarterID = 1
                },
                new SurveyResults
                {
                   QuestionID = 2,
                   type = "mc",
                   parentID = 7,
                   answerID = 2,
                   answer = "D",
                   groupID = 1,
                   quarterID = 1
                },
                new SurveyResults
                {
                   QuestionID = 2,
                   type = "mc",
                   parentID = 8,
                   answerID = 2,
                   answer = "D",
                   groupID = 1,
                   quarterID = 1
                }

            };
            return results;
        }
    }
}
