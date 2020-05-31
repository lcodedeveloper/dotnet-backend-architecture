using Repositorys.Strategies.Query.OrderBy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorys.Factories
{
    class OrderByFactory
    {
        public static IOrderByStratey Create(string description)
        {
            switch(description)
            {
                default:
                    return null;
            }
        }
    }
}
