public class SpanExtension
{
    public static Span<int> CreateSlices(Span<int> span)
    {
        Console.WriteLine(nameof(CreateSlices));
        int[] arr = { 3, 5, 7, 9, 11, 13, 15 };
        Span<int> span2 = new(arr);
        Span<int> span3 = new(arr, start: 3, length: 3);
        Span<int> span4 = span.Slice(start: 2, length: 4);

        displaySpan("content of span3", span3);
        displaySpan("content of span4", span4);
        return span2;
    }

    private static void displaySpan(string title, ReadOnlySpan<int> span)
    {
        Console.WriteLine($"title: {title}");
        for (int i = 0; i < span.Length; i++) Console.WriteLine($"{span[i]}");
        Console.WriteLine();
    }
}