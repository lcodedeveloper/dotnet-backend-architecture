using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Strategies.Crud
{
    public interface ICrudStrategy
    {
        void Create(object o);
        void Update(object o);
        IEnumerable<object> GetAll();
        object GetById(int id);
        void Delete(object o);
    }
}
