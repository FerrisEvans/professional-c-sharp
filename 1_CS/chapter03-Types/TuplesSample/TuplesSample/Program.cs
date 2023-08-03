// See https://aka.ms/new-console-template for more information
void IntroTyples()
{
    (string AString, int Number, Book Book) tuple1 = ("magic", 42, new Book("Professional C#", "Wrox Press"));
    Console.WriteLine($"a string: {tuple1.AString}, number: {tuple1.Number}, book: {tuple1.Book}");
}
IntroTyples();

var tuple2 = ("magic", 42, new Book("Professional C#", "Wrox Press"));
Console.WriteLine($"a string: {tuple2.Item1}, number: {tuple2.Item2}, book: {tuple2.Item3}");

var tuple3 = (AString: "magic", Number: 42, Book: new Book("Professional C#", "Wrox Press"));
Console.WriteLine($"a string: {tuple3.AString}, number: {tuple3.Number}, book: {tuple3.Book}");

(string S, int N, Book B) tuple4 = tuple3;
Console.WriteLine($"a string: {tuple4.S}, number: {tuple4.N}, book: {tuple4.B}");

Book book = new Book("Professional C#", "Wrox Press");
var tuple5 = (ANumber: 42, book.Title);
Console.WriteLine(tuple5.Title);

public record Book(string Title, string Publisher);