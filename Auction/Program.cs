using Auction;

var auction = new AuctionHouse();
var assistant = auction.GetEnumerator();

while (assistant.MoveNext())
{
    var car = assistant.Current as Car;
    Console.WriteLine(car?.Price);
}