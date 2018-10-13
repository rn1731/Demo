using SsoDemo.Authorization.Domain.Configuration;
using SsoDemo.Authorization.Domain.Model;

using SsoDemo.Framework.Api;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace SsoDemo.Authorization.Api
{
    public sealed class Startup : WebApiRegistration
    {

        public Startup(IConfiguration configuration) : base(configuration) { }

        public override void DependencyContainer(IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AuthorizationContext>(opt => opt.UseSqlServer(connection));

            services.AddScoped<IJwtConfig, JwtConfig>();

        }

        public override Dictionary<AssemblyType, Assembly> GetAssemblies()
        {
            return new Dictionary<AssemblyType, Assembly>
            {
                { AssemblyType.Controller, typeof(Controller.Registration).Assembly },
                { AssemblyType.Domain, typeof(Domain.Registration).Assembly }
            };
        }

        //optional CAN BE REMOVE if we need to disable authorization
        public override bool EnableAuthoriztion() { return false; }
    }


}
