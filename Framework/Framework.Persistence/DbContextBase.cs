using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Framework.Persistence
{
    public class DbContextBase : IdentityDbContext<IdentityUser>, IDbContext
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
