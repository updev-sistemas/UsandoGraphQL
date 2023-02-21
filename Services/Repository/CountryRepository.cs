using UsandoGraphQL.Database;
using UsandoGraphQL.Services.Contracts;

namespace UsandoGraphQL.Services.Repository
{
    public class CountryRepository : AbstractBaseRepository, ICountryRepository
    {
        public CountryRepository(DbLocalContext context) : base(context)
        {
        }
    }
}
