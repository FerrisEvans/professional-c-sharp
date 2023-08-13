int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int first1 = data[0];
int last1 = data[data.Length - 1];
Console.WriteLine($"first: {first1}, last: {last1}");

int last2 = data[^1];
Console.WriteLine(last2);

Index fisrtIndex = 0;
Index lastIndex = ^1;
int first3 = data[fisrtIndex];
int last3 = data[lastIndex];
Console.WriteLine($"first: {first3}, last: {last3}");

MyCollection coll = new();
int n = coll[^20];
Console.WriteLine($"Item from the collection: {n}");
ShowRange("Using custom collection", coll[45..^40]);

void ShowRange(string title, int[] data)
{
    Console.WriteLine(title);
    Console.WriteLine(string.Join(" ", data));
    Console.WriteLine($"");
}