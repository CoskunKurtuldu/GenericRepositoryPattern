using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicMarket.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicMarket.Data.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            //builder
            //    .HasKey(a => a.Id);

            //builder
            //    .Property(m => m.Id)
            //    .UseIdentityColumn();

            //builder
            //    .Property(m => m.Name)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //builder
            //    .ToTable("Artists");
        }
    }
}
