namespace Mediator;

interface AuctionMeditator {
    void RegisterBidder(Bidder bidder);
    void PlaceBid(Bidder bidder, decimal amount);
}

class AuctionHouse : AuctionMeditator {
    private List<Bidder> bidders = new List<Bidder>();

    public void RegisterBidder(Bidder bidder) {
        bidders.Add(bidder);
    }

    public void PlaceBid(Bidder bidder, decimal amount) {
        foreach (Bidder b in bidders)
        {
            b.ReceiveBid($"{bidder.getName()} has placed a bid of {amount:C}");
        }
    }
}

class Bidder {
    private string name;
    private AuctionMeditator mediator;
    public Bidder(string name, AuctionMeditator mediator) {
        this.name = name;
        this.mediator = mediator;
    }

    public string getName() {
        return name;
    }
    public void ReceiveBid(string message) {
        Console.WriteLine($"{name} received message: {message}");
    }
    public void PlaceBid(decimal amount) {
        mediator.PlaceBid(this, amount);
    }
}