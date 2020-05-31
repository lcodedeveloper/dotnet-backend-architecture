using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorys.Strategies.Query.Predicate
{
    public interface IPredicateStratey
    {
        IPredicate GetPredicate();
    }
}
