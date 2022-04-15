using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;




// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StaffMembers
{
    public partial class CtmSurveyIdentityDbContext : IdentityDbContext 
   // public partial class ctmsurveyContext : DbContext

    {
        public CtmSurveyIdentityDbContext(DbContextOptions<CtmSurveyIdentityDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           
        }

        
    }
}

