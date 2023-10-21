using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Abstract
{
    public interface IBase
    {
        public bool IsActive { get; set; }
        public Status Status { get; set; }
    }
}
