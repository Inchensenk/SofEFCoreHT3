using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2.Entities.Configurations
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {

        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.SerialNumber)
                   .IsRequired();

            //builder.HasAlternateKey(c=>c.SerialNumber);

        }


    }
}
