﻿using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOMS.DefinitionContext.Domain.Therapists;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.DefinitionContext.Persistence.Therapists
{
    public class TherapistMapping : EntityMappingBase<Therapist>
    {
        public override void Configure(EntityTypeBuilder<Therapist> builder)
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
