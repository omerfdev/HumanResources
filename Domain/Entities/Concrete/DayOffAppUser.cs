using Domain.Entities.Abstract;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class DayOffAppUser : IBase
    {
        public int DayOffAppUserId { get; set; }
        public int DayOffId { get; set; }
        public DayOff DayOff { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public byte RequestDayOff { get; set; }
        public bool IsActive { get ; set ; }
        public Status Status { get ; set ; }=Status.Pending;
        public DateTime? CreateTime { get ; set ; }
        public DateTime? ModifiedTime { get ; set ; }
        public DateTime? DeleteTime { get ; set ; }
        public DateTime? ReplyTime { get ; set ; }
        public DateTime? RequestTime { get ; set ; }= DateTime.Now;
    }
}
