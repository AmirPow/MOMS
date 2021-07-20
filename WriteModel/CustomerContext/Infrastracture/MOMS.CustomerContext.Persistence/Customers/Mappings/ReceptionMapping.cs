using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOMS.CustomerContext.Domain.Customers;
using System.Data;

namespace MOMS.CustomerContext.Persistence.Customers.Mappings
{
    public class ReceptionMapping : EntityMappingBase<Reception>
    {
        public override void Configure(EntityTypeBuilder<Reception> builder)
        {
            Initial(builder);
            builder.Property(a => a.PaymentNumber).HasMaxLength(250).IsRequired();
            builder.Property(a=>a.CustomerId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.DoctorId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.TherapistId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.ReceptionDateTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            builder.Property(a => a.Price).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            builder.Property(a => a.ExteraPrice).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            builder.Property(a => a.TotalPrice).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            builder.Property(a => a.Discount).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            builder.HasOne<Customer>().WithMany(a => a.Receptions).HasForeignKey(a => a.CustomerId);
        }
    }
}
