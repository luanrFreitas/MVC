using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Mappers
{
    public class ViewModelToModelProfile : Profile
    
    {
        MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<PessoaViewModel,Pessoa>();
        });
    }
}