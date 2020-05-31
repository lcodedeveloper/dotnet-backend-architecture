using Data.Entities;
using Data.Repositories.Contexts;
using Data.Repositories.Contracts;

namespace Data.Repositories
{
    public class DuckRepository : RepositoryBase<Duck>, IDuckRepository
    {
        private MainContext context;

        public DuckRepository(MainContext context) : base(context)
        {
            this.context = context;
        }
    }
}
