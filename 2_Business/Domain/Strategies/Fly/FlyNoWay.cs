using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Strategies.Fly
{
    class FlyNoWay : IFlyStrategy
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
