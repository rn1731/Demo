using SsoDemo.Authorization.Contract.Response;
using SsoDemo.Authorization.Domain.Configuration;
using AutoMapper;

namespace SsoDemo.Authorization.Domain.Mapping
{
    public class JwtConfigurationMapper : Profile
    {
        public JwtConfigurationMapper()
        {
            CreateMap<JwtConfig, JwtConfigurationResponse>();
        }
    }
}
