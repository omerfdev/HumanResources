
using Domain.Entities.Concrete;
using Domain.Repositories;

namespace HrELP.Infrastructure.Repositories
{
    public class AppRoleRepository: BaseRepository<AppRole>, IAppRoleRepository
    {
        public AppRoleRepository(Context context) : base(context)
        {

        }
    }
}
