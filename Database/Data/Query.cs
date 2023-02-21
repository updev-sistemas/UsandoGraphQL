using UsandoGraphQL.Entities;

namespace UsandoGraphQL.Database.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<City> GetCity([Service] DbLocalContext context) 
            => context.Cities!;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<State> GetState([Service] DbLocalContext context) 
            => context.States!;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Country> GetCountry([Service] DbLocalContext context)
            => context.Countries!;
    }
}
