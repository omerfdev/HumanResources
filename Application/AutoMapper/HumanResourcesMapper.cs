using Application.Models.DTOs.AppUserDTO;
using Application.Models.DTOs.SpendingTypeDTO;
using AutoMapper;
using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
    public class HumanResourcesMapper:Profile
    {
        public HumanResourcesMapper()
        {
            CreateMap<AppUser, AddEmployeeDTO>().ReverseMap();
            CreateMap<AppUser, UpdateEmployeeDTO>().ReverseMap();
            CreateMap<SpendingType, AddSpendingTypeDTO>().ReverseMap();
            CreateMap<SpendingType, UpdateSpendingTypeDTO>().ReverseMap();
        }
    }
}
