using AutoMapper;
using Repositories.Interfaces;
using Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;
using Microsoft.AspNetCore.Http;
using Repositories.Repositories;
using Service.Models;

namespace Services
{
    public static class Extensions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IParentRepository, ParentRepository>();

            MapperConfiguration config = new MapperConfiguration(
               conf => conf.CreateMap<Parent, ParentModel>()
               .ForMember(dest => dest.ParentId, opt => opt.MapFrom(dest => dest.ParentId))
               .ReverseMap()
               .ForMember(dest => dest.ParentId, opt => opt
               .MapFrom(dest => dest.ParentId)));
            IMapper mapper = config.CreateMapper();


            services.AddSingleton(mapper);
            services.AddDbContext<IDataSource, Context>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
    }
}
    