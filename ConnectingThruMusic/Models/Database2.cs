using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers.Models
{
    public class Database2
    {
        public static List<Roles> GetRoles()
        {
            List<Roles> roles = new List<Roles>
            {
                new Roles
                {
                    RoleName = "Admin"
                },

                new Roles
                {
                    RoleName2 = "User"
                }
            };
            return roles;
       }
    }
}
