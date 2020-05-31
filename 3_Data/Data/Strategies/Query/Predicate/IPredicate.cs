using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorys.Strategies.Query.Predicate
{
    public interface IPredicate
    {
        public string Query { get; set; }
        public Dictionary<string, object> Parameters { get; set; }
    }
}
