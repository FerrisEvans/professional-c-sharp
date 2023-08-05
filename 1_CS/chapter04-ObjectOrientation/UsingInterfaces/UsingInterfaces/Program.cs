Person p1 = new("Jackie", "Stewart");
Person p2 = new("Graham", "Hill");
Person p3 = new("Damon", "Hill");

Person[] people = { p1, p2, p3 };
Array.Sort(people);
foreach (var p in people) Console.WriteLine(p);

Ellipse e = new(new ConsoleLogger())
{
    Position = new(20, 30),
    Size = new(100, 120)
};
e.Draw();

