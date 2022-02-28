using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers
{
    public class Recipient
    {
        [Key]
        public int RecipientID { get; set; }
        public string RecipientType { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ChildName { get; set; }
        public int sessionID { get; set; }
        public int siteID { get; set; }
    }
}
