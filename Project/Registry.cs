// Project/Registry.cs
public class Registry
{
    private readonly List<Band> _items = new List<Band>();

    // TODO — Task 1. Say what your project is about, in words.
    public static string Topic => "Bands I like and want to see in concert";     // ← yours

    public Band NewItem(string name) => new Band(name);

    public void Add(Band item)
    {
        _items.Add(item);
    }

    public int Count => _items.Count;

    public List<Band> All()
    {
        // TODO — Task 5. Hand back a COPY, never the list itself.
        return _items;                                   // ← yours
    }
}