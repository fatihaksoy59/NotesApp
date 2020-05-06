using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Notes.Business.Abstract;
using TestCompany.Notes.DataAccess.Abstract;
using TestCompany.Notes.Entities.Concrete;

namespace TestCompany.Notes.Business.Concrete
{
    public class NoteManager : INoteService
    {
        private readonly INoteDal _noteDal;

        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }

        public Note Add(Note note)
        {
            _noteDal.Add(note);
            return note;
        }

        public void Delete(Note note)
        {
            _noteDal.Delete(note);
        }
        public void Update(Note note)
        {
            _noteDal.Update(note);
        }

        public List<Note> GetAll()
        {
            return _noteDal.GetList();
        }

        public Note GetById(int id)
        {
            return _noteDal.Get(n => n.ID == id);
        }
    }
}
