using DevFreela.Core.Repositories;
using DevFreela.Core.Services;
using DevFreela.Infrastructure.Auth;
using DevFreela.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<IAuthService, AuthService>();
        }
    }
}
