// 1. Change the struct to a class
// 2. Add a name tag as a string to the class and do the necessary changes to print all data

Coords[] coordinates = [new(1,2), new(3, 4)];

foreach (var c in coordinates)
{
    Console.WriteLine(c); // for not insert new line each time:  Console.Write(number);
}

public readonly struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public override string ToString() => $"({X}, {Y})";
}