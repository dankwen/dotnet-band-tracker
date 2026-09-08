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