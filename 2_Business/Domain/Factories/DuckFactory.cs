using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Abstractions.Duck.Factories
{
   public class DuckFactory
    {
        public static Duck Create(string description)
        {
            switch(description)
            {
                case "mallard":
                    return new MallardDuck();
                case "redhead":
                    return new RedheadDuck();
            }

            return null;
        }
    }
}
