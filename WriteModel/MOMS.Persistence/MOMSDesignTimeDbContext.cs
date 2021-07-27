using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace MOMS.Persistence
{
    public class TMSDesignTimeDbContext : IDesignTimeDbContextFactory<MOMSDbContext>
    {
        public MOMSDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MOMSDbContext>();
           optionsBuilder.UseSqlServer("Server =.,1433;Data Source=.;Database = MOMS_Developer;Integrated Security=true;");
           // optionsBuilder.UseSqlServer("data source= 185.55.224.3 ;Initial Catalog=dahriman_MOMS  ;User Id=dahriman_DevADUser ;password=@N379645099_A_M ;");
            return new MOMSDbContext(optionsBuilder.Options);
        }
    }
}
