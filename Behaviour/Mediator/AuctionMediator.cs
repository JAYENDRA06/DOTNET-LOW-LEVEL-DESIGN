namespace Mediator;

// THEORY: simplifies communication between multiple objects by centralizing interactions through a mediator object, promoting loose coupling.

interface AuctionMediator {
    void RegisterBidder(Bidder bidder);
    void PlaceBid(Bidder bidder, decimal amount);
}

class AuctionHouse : AuctionMediator {
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

// similarly we can have other auction mediators like RealEstateAuction, CarAuction etc.

class Bidder {
    private string name;
    private AuctionMediator mediator;
    public Bidder(string name, AuctionMediator mediator) {
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