using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Notes.Entities.Concrete;

namespace TestCompany.Notes.DataAccess.Seeds
{
    class NoteSeed : IEntityTypeConfiguration<Note>
    {


        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasData(
                new Note { ID = 1, NoteName = "Test", NoteData = "Deneme", Status = 1 }
                );
        }
    }
}
