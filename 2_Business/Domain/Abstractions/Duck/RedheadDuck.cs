using Domains.Strategies.Fly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Abstractions.Duck
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {

        }
        public RedheadDuck(IFlyStrategy fly) : base(fly)
        {
        }
    }
}
