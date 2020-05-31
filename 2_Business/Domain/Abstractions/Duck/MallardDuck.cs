using System;
using System.Collections.Generic;
using System.Text;
using Domains.Strategies.Fly;

namespace Domains.Abstractions.Duck
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {

        }
        public MallardDuck(IFlyStrategy fly) : base(fly)
        {
        }
    }
}
