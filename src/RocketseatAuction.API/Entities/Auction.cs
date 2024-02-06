namespace RocketseatAuction.API.Entities;

public class Auction
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Starts { get; set; } = DateTime.Now;
    public DateTime Ends { get; set; }

    public List<Item> Items { get; set; } = [];
}
