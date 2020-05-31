using Repositorys.Strategies.Query.Predicate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorys.Factories
{
    class PredicadoFactory
    {
        public static IPredicateStratey Create(string predicate)
        {
            switch(predicate)
            {
                default:
                    return null;
            }
        }

        public static IPredicate CreatePoco(string predicate)
        {
            switch (predicate) {
                default:
                    return new Predicate();
            }           

        }
    }
}
