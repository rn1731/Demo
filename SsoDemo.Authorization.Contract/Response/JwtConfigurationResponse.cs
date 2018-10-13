
namespace SsoDemo.Authorization.Contract.Response
{
    public class JwtConfigurationResponse
    {
        public string Audience { get; set; }
        public string Subject { get; set; }
        public string Issuer { get; set; }
        public string RsaPublicKey { get; set; }
    }
}
