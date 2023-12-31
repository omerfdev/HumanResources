﻿using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IDayOffRepository: IBaseRepository<DayOff>
    {
        IQueryable<DayOff> GetUserWithRequestsAsync();
    }
}
