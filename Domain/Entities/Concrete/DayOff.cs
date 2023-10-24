using Domain.Entities.Abstract;
using Domain.Entities.Enum;


namespace Domain.Entities.Concrete
{
    public class DayOff : IBase
    {
        public int DayOffId { get; set; }       
        public DayOffType DayOffType { get; set; }
        public byte DayOffTypeId { get; set; }
        public string Description { get; set; }
        public byte DayOffDayNumber { get; set; }
        public AppUser Employee { get; set; }       
        public int EmployeeId { get; set; }
        public Gender Gender { get; set; }
        public bool IsActive { get ; set ; }
        public Status Status { get; set; } = Status.Pending;
        public DateTime? CreateTime { get ; set ; }
        public DateTime? ModifiedTime { get ; set ; }
        public DateTime? DeleteTime { get ; set ; }
        public DateTime? ReplyTime { get ; set ; }
        public DateTime? RequestTime { get ; set ; }
        public DateTime? DayOffStartTime { get; set; } 
        public DateTime? DayOffEndTime { get ; set ; }
        public DayOff()
        {
            if (DayOffDayNumber > 0)
            {
                DayOffStartTime = RequestTime;
                DayOffEndTime = DayOffStartTime.Value.AddDays(DayOffDayNumber);
            }
        }
    }
}
