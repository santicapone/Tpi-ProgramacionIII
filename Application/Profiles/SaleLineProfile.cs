using Application.Models;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    internal class SaleLineProfile : Profile
    {
        public SaleLineProfile() 
        {
            CreateMap<SaleLineDto, SaleLine>();
            CreateMap< SaleLine , SaleLineDto>();
        }
    }
}
