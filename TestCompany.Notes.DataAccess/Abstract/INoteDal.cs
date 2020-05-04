using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Core.DataAccess;
using TestCompany.Notes.Entities.Concrete;

namespace TestCompany.Notes.DataAccess.Abstract
{
    public interface INoteDal : IEntityRepository<Note>
    {
    }
}
