using HomeCine.Data.Base;
using HomeCine.Models;

namespace HomeCine.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context): base(context)
        {

        }
    }
}
