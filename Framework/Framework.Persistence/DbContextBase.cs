using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Persistence;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MOMS.UserContext.Domain;

namespace Framework.Persistence
{
    public class DbContextBase : IdentityDbContext<ApplicationUser>, IDbContext
    {
        public DbContextBase(DbContextOptions options) : base(options)
        {

        }

        public void Migrate()
        {
            base.Database.Migrate();
        }




    }
}
