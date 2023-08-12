var persons = new Person[]
{
    new("Damon", "Hill"),
    new("Niki", "Lauda"),
    new("Ayrton", "Senna"),
    new("Graham", "Hill"),
};

Array.Sort(persons);
foreach(var p in persons) Console.WriteLine(p);

Console.WriteLine($"-------");
Array.Sort(persons, new PersonCompare(PersonCompareType.FirstName));
foreach(var p in persons) Console.WriteLine(p);