﻿using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOMS.DefinitionContext.Domain.Doctors;
using System.Data;

namespace MOMS.DefinitionContext.Persistence.Doctors
{
    public class DoctorMapping : EntityMappingBase<Doctor>
    {
        public override void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(a => a.FirstName).HasMaxLength(250).IsRequired(false);
            builder.Property(a => a.LastName).HasMaxLength(250).IsRequired();
            builder.Property(a => a.FatherName).HasMaxLength(250).IsRequired(false);
            builder.Property(a => a.NationalCode).HasMaxLength(10).IsRequired(false);
            builder.Property(a => a.MobileNumber).HasMaxLength(11).IsRequired(false);
            builder.Property(a => a.PhoneNumber).HasMaxLength(11).IsRequired(false);
            builder.Property(a => a.Gender).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            builder.Property(a => a.MartialStatus).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
            builder.Property(a => a.RegDateTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
        }
    }
}
