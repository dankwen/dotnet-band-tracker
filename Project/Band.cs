public class Band
{
    // TODO — Task 2. These three are holes: anything, anywhere, can write
    // anything into them. Close every one into a property.
    // Task 3 gives one of them a rule; Task 4 seals one shut.
    private string _name = "(unknown)";
    public string Name
    {
        get { return _name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _name = value.Trim();
            }
        }
    }
    
    public string Style { get; set; } = "(unknown)";
    
    private int _yearFounded = 0;
    public int YearFounded
    {
        get { return _yearFounded; }
        set
        {
            if (value >= 0)
            {
                _yearFounded = value;
            }
        }
    }

    public Band(string name)
    {
        Name = name;
        Style = "";
    }
}