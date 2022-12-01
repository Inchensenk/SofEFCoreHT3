using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2.Entities.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(s=>s.Id);

            /*Отношение "могие ко многим":
             * В данном случае зачетка может иметь множество предметов и предмет может иметь множество зачеток
             * .HasMany(c => c.Cards): множество зачеток 
             * .WithMany(s => s.Subjects): множество предметов
             * .UsingEntity(cs=>cs.ToTable("Enrollments"): явное указание имени промежуточной таблицы "Enrollments" между сущностью зачетка и сущностью предмет 
             * Если не задавать название таблицы явно, то Entity Framework Core автомотически создаст таблицу с составным названием из связанных сущностей
             */
            builder.HasMany(c => c.Cards).WithMany(s => s.Subjects).UsingEntity(cs=>cs.ToTable("Enrollments"));
        }
    }
}
