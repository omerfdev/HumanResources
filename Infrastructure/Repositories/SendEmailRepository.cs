using Domain.Entities.Concrete;
using Domain.Repositories;
using HrELP.Infrastructure;
using HrELP.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SendEmailRepository : BaseRepository<SendEmail>, ISendEmailRepository
    {
        public SendEmailRepository(Context context) : base(context)
        {
        }
    }
}
