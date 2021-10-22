using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIPrincipal.DTOs;
using APIPrincipal.Models;
using AutoMapper;

namespace APIPrincipal.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Games, GamesRequestDto>().ReverseMap();
        }
    }
}
