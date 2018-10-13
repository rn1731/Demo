using Microsoft.Extensions.Configuration;
using System.IO;

namespace SsoDemo.Authorization.Domain.Configuration
{
    public class JwtConfig : IJwtConfig
    {
        private readonly IConfiguration _configuration;

        public JwtConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Secret => _configuration.GetSection("JWT:Secret").Value;
        public string Audience => _configuration.GetSection("JWT:Audience").Value;
        public string Subject => _configuration.GetSection("JWT:Subject").Value;
        public string Issuer => _configuration.GetSection("JWT:Issuer").Value;
        public string RsaPublicKey => GetPublicKey();
        public string RsaPrivateKey => GetPrivateKey();

        private string GetPrivateKey()
        {
            var keysPath = Path.Combine(Directory.GetCurrentDirectory(), "Key");
            return File.ReadAllText(Path.Combine(keysPath, _configuration.GetSection("JWT:RsaPrivateKey").Value));
        }

        private string GetPublicKey()
        {
            var keysPath = Path.Combine(Directory.GetCurrentDirectory(), "Key");
            return File.ReadAllText(Path.Combine(keysPath, _configuration.GetSection("JWT:RsaPublicKey").Value));
        }
    }
}
