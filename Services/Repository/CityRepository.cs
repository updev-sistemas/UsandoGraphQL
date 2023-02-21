using UsandoGraphQL.Database;
using UsandoGraphQL.Services.Contracts;

namespace UsandoGraphQL.Services.Repository
{
    public class CityRepository : AbstractBaseRepository, ICityRepository
    {
        public CityRepository(DbLocalContext context) : base(context)
        {
        }
    }
}
