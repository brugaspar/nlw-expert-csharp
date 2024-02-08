using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase(IAuctionRepository repository)
{
    public Auction? Execute()
    {
        return repository.GetCurrent();
    }
}
