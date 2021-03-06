﻿using ClassifiedAds.DomainServices.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassifiedAds.Persistence.MappingConfigurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable("Sessions");
            builder.Property(x => x.Id).HasDefaultValueSql("newsequentialid()");
        }
    }
}
