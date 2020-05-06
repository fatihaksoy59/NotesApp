using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Core.Entities;

namespace TestCompany.Notes.Entities.Concrete
{
    public class Note:IEntity
    {
        public int ID { get; set; }
        public int Status { get; set; }

        //LastUpdated ekle
        public string NoteName { get; set; }
        public string NoteData { get; set; }
    }
}
