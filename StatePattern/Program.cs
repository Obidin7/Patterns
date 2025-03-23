using StatePattern;

var owner = new Owner();

while (true)
{
    Console.WriteLine("\nEnter Gain(1) or Loss(2):\n");

    Profit mark = (Profit)Enum.Parse(typeof(Profit), Console.ReadLine());

    if (mark == Profit.Loss || mark == Profit.Gain)
    {
        owner.FindOut(mark);
    }
}