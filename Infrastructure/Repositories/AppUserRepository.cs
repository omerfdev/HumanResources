using Domain.Entities.Concrete;
using Domain.Repositories;


namespace HrELP.Infrastructure.Repositories
{
    public class AppUserRepository: BaseRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(Context context) : base(context)
        {

        }
    }
}
