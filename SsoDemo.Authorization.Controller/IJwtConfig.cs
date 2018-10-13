namespace SsoDemo.Authorization.Domain.Configuration
{
    public interface IJwtConfig
    {
        string Secret { get; }
        string Audience { get; }
        string Subject { get; }
        string Issuer { get; }
        string RsaPublicKey { get; }
        string RsaPrivateKey { get; }
    }
}
