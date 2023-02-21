using UsandoGraphQL.Database;

namespace UsandoGraphQL.Services.Repository
{
    public abstract class AbstractBaseRepository
    {
        protected readonly DbLocalContext? db;

        protected AbstractBaseRepository(DbLocalContext context)
        {
            this.db = context;
        }
    }
}
