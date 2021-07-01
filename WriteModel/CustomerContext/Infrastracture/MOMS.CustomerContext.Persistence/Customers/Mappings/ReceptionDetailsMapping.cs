using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOMS.CustomerContext.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Persistence.Customers.Mappings
{
    public class ReceptionDetailsMapping : EntityMappingBase<ReceptionDetails>
    {
        public override void Configure(EntityTypeBuilder<ReceptionDetails> builder)
        {
            builder.Property(a => a.ReceptionId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.ProcedureId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.HasOne<Reception>().WithMany(a=>a.ReceptionDetails).HasForeignKey(x => x.ReceptionId).IsRequired();
        }
    }
}
