using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Mappers
{
    public class AutoMapperConfig
    {

        public static void RegisterMapping()
        {
            Mapper.Initialize(cfg =>
                {
                    cfg.AddProfile<ModelToViewModelProfile>();
                    cfg.AddProfile<ViewModelToModelProfile>();

                });
        }
    }
}
