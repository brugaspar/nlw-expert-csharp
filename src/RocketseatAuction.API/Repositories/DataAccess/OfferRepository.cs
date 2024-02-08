using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class OfferRepository(RocketseatAuctionDbContext repository) : IOfferRepository
{
    public void Add(Offer offer)
    {
        repository.Offers.Add(offer);
        repository.SaveChanges();
    }
}
