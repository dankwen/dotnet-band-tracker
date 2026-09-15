public class Band
{
    private string _name = "(unnamed)";
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
    
    public string Style { get; set; } = "(generic)";
    
    private int _timesSeen = 0;
    public int TimesSeen
    {
        get { return _timesSeen; } 
        private set { if (value >= 0) { _timesSeen = value; } }
    }

    public Band(string name)
    {
        Name = name;
        Style = "";
    }

    public void SeeBand()
    {
        _timesSeen++;
    }
}