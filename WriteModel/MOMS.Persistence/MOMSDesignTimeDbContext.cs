using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.Persistence
{
    public class TMSDesignTimeDbContext : IDesignTimeDbContextFactory<MOMSDbContext>
    {
        public MOMSDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MOMSDbContext>();

            optionsBuilder.UseSqlServer("Server =.,1433;Data Source=.;Database = MOMS_Developer;Integrated Security=true;");
            return new MOMSDbContext(optionsBuilder.Options);
        }
    }
}
