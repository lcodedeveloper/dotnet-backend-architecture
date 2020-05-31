using Repositorys.Strategies.Query.Join;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorys.Factories
{
    class JoinFactory
    {
        public static IJoinStratey Create(string description)
        {
            switch(description)
            {
                default:
                    return null;
            }
        }
    }
}
