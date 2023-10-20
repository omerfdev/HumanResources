using Domain.Entities.Abstract;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete
{
    public class Address:IBase
    {
        public int AddressId { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string District { get; set; }
        public string Quarter { get; set; }
        public int PostalCode { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public Status Status { get; set; }

        public override string ToString()
        {
            return $"{Quarter} {District} {Town} {PostalCode} {City}";
        }
    }
}
