namespace Mediator;

public class Handler {
    public static void Handle() {
        AuctionMediator auctionHouse = new AuctionHouse();

        Bidder bidder1 = new Bidder("Alice", auctionHouse);
        Bidder bidder2 = new Bidder("Bob", auctionHouse);
        Bidder bidder3 = new Bidder("Charlie", auctionHouse);

        auctionHouse.RegisterBidder(bidder1);
        auctionHouse.RegisterBidder(bidder2);
        auctionHouse.RegisterBidder(bidder3);

        bidder1.PlaceBid(100);
        bidder2.PlaceBid(150);
        bidder3.PlaceBid(200);
    }
}