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
    public class PaymentMapping : EntityMappingBase<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.Property(a => a.ReceptionId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.PeymentDateTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            builder.Property(a => a.Cash).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            builder.Property(a => a.Pose).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            builder.HasOne<Reception>().WithMany(a => a.Peyments).HasForeignKey(x => x.ReceptionId);
        }
    }
}
