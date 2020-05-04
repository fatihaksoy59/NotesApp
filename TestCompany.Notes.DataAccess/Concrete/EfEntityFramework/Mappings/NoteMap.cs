using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Notes.Entities.Concrete;

namespace TestCompany.Notes.DataAccess.Concrete.EfEntityFramework.Mappings
{
    public class NoteMap : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(n => n.ID);
            builder.Property(n => n.ID).UseIdentityColumn();

            builder.Property(n => n.Status).HasDefaultValue(1);

            builder.Property(n => n.NoteName).IsRequired().HasMaxLength(15);
            builder.Property(n => n.NoteData).IsRequired();

        }
    }
}
