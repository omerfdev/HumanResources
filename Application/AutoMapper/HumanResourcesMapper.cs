using Application.Models.DTOs.AppUserDTO;
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
        }
    }
}
