using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class UserRepository(RocketseatAuctionDbContext repository) : IUserRepository
{
    public bool ExistsUserWithEmail(string email)
    {
        return repository.Users.Any(user => user.Email.Equals(email));
    }

    public User GetByEmail(string email)
    {
        return repository.Users.First(user => user.Email.Equals(email));
    }
}
