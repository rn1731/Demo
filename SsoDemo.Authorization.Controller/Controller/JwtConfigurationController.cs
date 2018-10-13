using SsoDemo.Authorization.Contract.Response;
using SsoDemo.Authorization.Domain.Configuration;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace SsoDemo.Authorization.Controller.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtConfigurationController : ControllerBase
    {
        private readonly IJwtConfig _jwtConfig;
        private readonly IMapper _mapper;

        public JwtConfigurationController(IJwtConfig jwtConfig, IMapper mapper)
        {
            _jwtConfig = jwtConfig;
            _mapper = mapper;
        }

        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public JwtConfigurationResponse GetJwtConfiguration()
        {
            return _mapper.Map<JwtConfigurationResponse>(_jwtConfig);
        }
    }
}
