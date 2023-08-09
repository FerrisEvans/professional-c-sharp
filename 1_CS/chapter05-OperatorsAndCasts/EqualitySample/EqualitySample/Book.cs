public class Book : IEquatable<Book>
{

    public string Title { get; }
    public string Publisher { get; }

    protected virtual Type EqualityContract { get; } = typeof(Book);
    public override string ToString() => Title;
    
    public Book(string title, string publisher)
    {
        
    }

    public bool Equals(object obj) => this == obj as Book;
    public bool Equals(Book? other) => this == other;

    public override int GetHashCode() => Title.GetHashCode() ^ Publisher.GetHashCode();

    public static bool operator ==(Book? left, Book? right) =>
        left?.Title == right?.Title && left?.Publisher == right?.Publisher &&
        left?.EqualityContract == right?.EqualityContract;

    public static bool operator !=(Book? left, Book? right) => !(left == right);
}