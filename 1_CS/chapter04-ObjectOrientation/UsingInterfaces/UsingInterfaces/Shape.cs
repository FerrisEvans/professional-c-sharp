public abstract class Shape
{
    protected ILogger Logger { get; }
    public Position? Position { get; init; }
    public Size? Size { get; init; }


    public Shape(ILogger logger) => Logger = logger;

    protected virtual void DisplayShape() => Console.WriteLine($"Shape with {Position} and {Size}");

    public void Draw() => DisplayShape();

}

public record Position(int X, int Y);

public record Size(int Width, int Height);