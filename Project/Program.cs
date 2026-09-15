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

// Your verb, on two of your records — watch only one of them move.
List<Band> both = registry.All();
Console.WriteLine($"before:  {both[0].TimesSeen}   {both[1].TimesSeen}");
both[0].SeeBand();
Console.WriteLine($"after:   {both[0].TimesSeen}   {both[1].TimesSeen}");