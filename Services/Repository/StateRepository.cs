using UsandoGraphQL.Database;
using UsandoGraphQL.Services.Contracts;

namespace UsandoGraphQL.Services.Repository
{
    public class StateRepository : AbstractBaseRepository, IStateRepository
    {
        public StateRepository(DbLocalContext context) : base(context)
        {
        }
    }
}
