﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.lnfra.loC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            //application layer
            services.AddScoped<ICourseService, CourseService>();

            //infrastructer.data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
