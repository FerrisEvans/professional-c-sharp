var list = new LinkedList<Document>();
LinkedListNode<Document> first = list.AddFirst(new Document(1, "first"));
list.AddAfter(first, new Document(2, "second"));
LinkedListNode<Document> last = list.AddLast(new Document(3, "last"));
Document d = new(4, "before last");
list.AddBefore(last, d);

foreach (var document in list)
{
    Console.WriteLine($"{document}");
}

public record Document(int Id, string Text);