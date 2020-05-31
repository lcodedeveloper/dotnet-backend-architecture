using Domains.Abstractions.Duck;
using Domains.Abstractions.Duck.Factories;
using Facade.Contracts;

namespace Facades
{
    public class DuckFacade : IDuckFacade
    {
        private Duck mallardDuck;
        private Duck redheadDuck;

        public DuckFacade()
        {
            mallardDuck = DuckFactory.Create("mallard");
            redheadDuck = DuckFactory.Create("redhead");
        }

        public void FlyMallard()
        {
            mallardDuck.Fly();
        }

        public void FlyRedhead()
        {
            redheadDuck.Fly();
        }

        public void CreateMallard(object o)
        {
            mallardDuck.Create(o);
        }

        public void UpdateMallard(object o)
        {
            mallardDuck.Update(o);
        }

        public void CreateRedhead(object o)
        {
            redheadDuck.Create(o);
        }

        public void UpdateReadhead(object o)
        {
            redheadDuck.Update(o);
        }
    }
}
