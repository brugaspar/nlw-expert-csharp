using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Services;

public class LoggedUser(IHttpContextAccessor httpContextAccessor, IUserRepository repository) : ILoggedUser
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public User User()
    {
        var token = TokenOnRequest();
        var email = FromBase64String(token);

        return repository.GetByEmail(email);
    }

    private string TokenOnRequest()
    {
        var authorization = _httpContextAccessor.HttpContext!.Request.Headers.Authorization.ToString();
        return authorization["Bearer ".Length..];
    }

    private string FromBase64String(string base64)
    {
        var data = Convert.FromBase64String(base64);
        return System.Text.Encoding.UTF8.GetString(data);
    }
}
