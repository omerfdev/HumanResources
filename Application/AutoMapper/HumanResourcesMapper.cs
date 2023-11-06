using Application.Models.DTOs.AppUserDTO;
using Application.Models.DTOs.CompanyDTO;
using Application.Models.DTOs.DepartmentDTO;
using Application.Models.DTOs.SpendingDTO;
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
            CreateMap<Spending, AddSpendingDTO>().ReverseMap();
            CreateMap<Spending, UpdateSpendingDTO>().ReverseMap();
            CreateMap<Department, AddDepartmentDTO>().ReverseMap();
            CreateMap<Department, UpdateDepartmentDTO>().ReverseMap();
            CreateMap<Company, AddCompanyDTO>().ReverseMap();
            CreateMap<Company, UpdateCompanyDTO>().ReverseMap();
        }
    }
}
