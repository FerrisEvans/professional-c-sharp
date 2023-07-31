// See https://aka.ms/new-console-template for more informatio

Console.WriteLine("Hello, World!");

TrafficLight NextLightClassic(TrafficLight light)
{
    switch (light)
    {
        case TrafficLight.Green:
            return TrafficLight.Amber;
        case TrafficLight.Amber:
            return TrafficLight.Red;
        case TrafficLight.Red:
            return TrafficLight.Green;
        default:
            throw new InvalidOperationException();
    }
}

// since c# 8
TrafficLight NextLight(TrafficLight light) =>
    light switch
    {
        TrafficLight.Green => TrafficLight.Amber,
        TrafficLight.Amber => TrafficLight.Red,
        TrafficLight.Red => TrafficLight.Green,
        _ => throw new InvalidOperationException()
    };

string? input = Console.ReadLine();

string result = input switch
{
    "one" => "the input has the value one",
    "two" or "three" => "the input has the value two or three",
    _ => "any other value"
};

enum TrafficLight
{
    Red,
    Amber,
    Green
}