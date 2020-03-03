namespace JWTMicroNetCore.Services
{
    public interface ITokenBuilder
    {
        string BuildToken(string username);
    }
}
