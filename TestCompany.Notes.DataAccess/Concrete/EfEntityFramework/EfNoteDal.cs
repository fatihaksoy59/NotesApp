using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TestCompany.Core.DataAccess.EntityFramework;
using TestCompany.Notes.DataAccess.Abstract;
using TestCompany.Notes.Entities.Concrete;

namespace TestCompany.Notes.DataAccess.Concrete.EfEntityFramework
{
    public class EfNoteDal : EfEntityRepositoryBase<Note,NoteProjectContext>, INoteDal
    {
       
    }
}
