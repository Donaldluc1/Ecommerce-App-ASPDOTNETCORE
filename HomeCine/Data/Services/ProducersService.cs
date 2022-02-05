using HomeCine.Data.Base;
using HomeCine.Models;

namespace HomeCine.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context): base(context)
        {

        }
    }
}
