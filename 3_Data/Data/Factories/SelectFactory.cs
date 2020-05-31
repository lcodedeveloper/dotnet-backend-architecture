using Repositorys.Strategies.Query.Select;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorys.Factories
{
    class SelectFactory
    {
        public static ISelectStrategy Create(string description)
        {
            switch(description)
            {
                default:
                    return null;
            }
        }
    }
}
