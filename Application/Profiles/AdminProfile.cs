using Application.Models;
using Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    internal class AdminProfile : Profile
    {
        public AdminProfile() 
        {
            CreateMap<AdminDto, Admin>();
            CreateMap<Admin, AdminDto>();
        }
    }
}
