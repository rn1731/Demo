namespace SsoDemo.Authorization.Contract.Request
{
    public class AuthenticationRequest
    {
        public string ClientKey { get; set; }
        public string ClientSecret { get; set; }
        public string GrantType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
