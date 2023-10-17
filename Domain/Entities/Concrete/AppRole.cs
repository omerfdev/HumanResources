using Domain.Entities.Abstract;
using Domain.Entities.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class AppRole : IdentityRole<int>, IBase
    {
        public Status Status { get; set; }
    }
}
