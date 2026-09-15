// Project/Program.cs — swap Band for your record's name, and print your own facts
var registry = new Registry();

registry.Add(new Band("The Cure"));
registry.Add(new Band("Teenage Bottlerocket"));
registry.Add(new Band("The Smoking Popes"));

Console.WriteLine(Registry.Topic);
Console.WriteLine($"{registry.Count} on file.");
Console.WriteLine();

foreach (Band item in registry.All())
{
    Console.WriteLine(item.Name);
}

Console.WriteLine();

List<Band> both = registry.All();
Console.WriteLine($"before:  {both[0].TimesSeen}   {both[1].TimesSeen}");
both[0].SeeBand();
Console.WriteLine($"after:   {both[0].TimesSeen}   {both[1].TimesSeen}");

Console.WriteLine();

// One I know is on the registry.
Band? known = registry.Find("The Cure");
Console.WriteLine(known == null ? "Nothing on file by that name." : "Found it.");

// And one nobody has ever heard of.
Band? missing = registry.Find("Nickelback");
Console.WriteLine(missing == null ? "Nothing on file by that name." : "...found something that shouldn't be there.");

Console.WriteLine();
Console.WriteLine(registry.Remove("The Cure")
    ? "Removed."
    : "Nothing by that name.");
Console.WriteLine($"{registry.Count} on file.");