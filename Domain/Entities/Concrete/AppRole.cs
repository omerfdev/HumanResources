﻿using Domain.Entities.Abstract;
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
        public bool IsActive { get ; set ; }
        public DateTime? CreateTime { get ; set ; }
        public DateTime? ModifiedTime { get ; set ; }
        public DateTime? DeleteTime { get ; set ; }
        public DateTime? ReplyTime { get ; set ; }
        public DateTime? RequestTime { get ; set ; }
    }
}
