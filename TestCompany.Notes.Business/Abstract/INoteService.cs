using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Notes.Entities.Concrete;

namespace TestCompany.Notes.Business.Abstract
{
    public interface INoteService
    {
        List<Note> GetAll();
        Note GetById(int id);
        Note Add(Note note);
        void Update(Note note);
        void Delete(Note note);
        
    }
}
