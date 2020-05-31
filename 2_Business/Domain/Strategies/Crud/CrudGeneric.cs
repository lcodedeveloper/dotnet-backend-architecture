using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Strategies.Crud
{
    class CrudGeneric : ICrudStrategy
    {
        public void Create(object o)
        {
            throw new NotImplementedException();
        }

        public void Delete(object o)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(object o)
        {
            throw new NotImplementedException();
        }
    }
}
