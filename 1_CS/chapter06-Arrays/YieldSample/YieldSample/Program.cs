var titles = new MusicTitles();

foreach (var title in titles)
{
    Console.WriteLine($"{title}");
}
Console.WriteLine();

Console.WriteLine("Reverse");
foreach (var title in titles.Reverse())
{
    Console.WriteLine($"reverse: {title}");
}
Console.WriteLine();

Console.WriteLine("Subset");
foreach (var title in titles.Subset(2, 2))
{
    Console.WriteLine($"Subset: {title}");
}