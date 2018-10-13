namespace SsoDemo.Authorization.Contract.Request
{
    public class RefreshTokenRequest
    {
        public string ClientKey { get; set; }
        public string ClientSecret { get; set; }
        public string RefreshToken { get; set; }
    }
}
