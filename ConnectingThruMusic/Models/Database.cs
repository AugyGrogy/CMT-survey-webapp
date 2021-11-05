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

    }
}
