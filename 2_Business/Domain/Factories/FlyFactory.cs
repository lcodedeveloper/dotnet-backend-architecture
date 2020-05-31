using Domains.Strategies.Fly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Abstractions.Duck.Factories
{
    class FlyFactory
    {
        public static IFlyStrategy Create(string description)
        {
            switch(description)
            {
                case "FlyNoWay":
                    return new FlyNoWay();
                case "FlyWithWings":
                    return new FlyWithWings();
            }

            return null;
        }
    }
}
