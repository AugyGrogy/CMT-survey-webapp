namespace StaffMembers.Models
{
    public class SurveyResults
    {
        public int QuestionID { get; set; }
        public string type { get; set; }
        public int instructorID { get; set; }
        public int parentID { get; set; }
        public int answerID { get; set; }
        public string answer { get; set; }
        public int groupID { get; set; }
        public int quarterID { get; set; }
    }
}
