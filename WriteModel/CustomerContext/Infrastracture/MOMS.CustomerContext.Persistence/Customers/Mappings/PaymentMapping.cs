using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOMS.CustomerContext.Domain.Customers;
using System.Data;

namespace MOMS.CustomerContext.Persistence.Customers.Mappings
{
    public class PaymentMapping : EntityMappingBase<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.Property(a => a.ReceptionId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.PaymentDateTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            builder.Property(a => a.Cash).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            builder.Property(a => a.Pose).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            builder.HasOne<Reception>().WithMany(a => a.Payments).HasForeignKey(x => x.ReceptionId);
        }
    }
}
