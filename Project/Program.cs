// Project/Program.cs — swap Band for your record's name, and print your own facts
var registry = new Registry();

registry.Add(new Band("The Cure"));
registry.Add(new Band("Teenage Bottlerocket"));
registry.Add(new Band("The Smoking Popes"));

Console.WriteLine(Registry.Topic);
Console.WriteLine($"{registry.Count} on file.");
Console.WriteLine();

// One I know something about.
Band? known = registry.Find("Teenage Bottlerocket");
if (known == null)
{
    Console.WriteLine("Nothing on file by that name.");
}
else
{
    known.SeeBand();
    Console.WriteLine($"{known.Name} - visited {known.TimesSeen}x");
}

// And one nobody has ever heard of.
Band? missing = registry.Find("Nickelback");
Console.WriteLine(missing == null
    ? "Nothing on file by that name."
    : "...found something that shouldn't be there.");

Console.WriteLine();
Console.Write("Take one off the books (Enter to skip): ");
string? name = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine(registry.Remove(name) ? "Removed." : "Nothing by that name.");
}

Console.WriteLine();
foreach (Band item in registry.All())
{
    Console.WriteLine(item.Name);
}
Console.WriteLine($"{registry.Count} on file.");