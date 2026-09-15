// Project/Registry.cs
public class Registry
{
    private readonly List<Band> _items = new List<Band>();

    public static string Topic => "Bands I like and want to see in concert";

    public Band NewItem(string name) => new Band(name);

    public void Add(Band item)
    {
        _items.Add(item);
    }

    public int Count => _items.Count;

    public List<Band> All()
    {
        return new List<Band>(_items);
    }

    public Band? Find(string name)
    {
        foreach (Band item in _items)
        {
            if (item.Name == name)
            {
                return item;
            }
        }
        return null;
    }

    public bool Remove(string name)
    {
        Band? found = Find(name);
        if (found == null) { return false; }

        _items.Remove(found);
        return true;
    }
}