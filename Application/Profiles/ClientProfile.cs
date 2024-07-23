using Application.Models;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    internal class ClientProfile : Profile
    {
       public ClientProfile() 
        {
            CreateMap<ClientDto, Client>();
            CreateMap<Client, ClientDto>();
        }
    }
}
