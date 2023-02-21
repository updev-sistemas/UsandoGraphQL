using Microsoft.AspNetCore.Mvc;
using UsandoGraphQL.Database;

namespace UsandoGraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly DbLocalContext? _db;

        public CountryController(DbLocalContext dbLocalContext)
        {
            this._db = dbLocalContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var collection = this._db!.Countries!.ToArray();

            return Ok(collection);
        }
    }
}
