List<string> leksaker = ["Bil", "Lego", "Pussel", "Cykel", "Boll"];
List<string> Namn = ["Rasmus", "Simon", "Wiggo", "Elias", "Bullen"];
List<int> nummer = [1, 4, 8, 5, 2];
List<string> Cities = [];



for (int i = 0; i < leksaker.Count; i++)
{
    Console.WriteLine($"{Namn[i]} ger {leksaker[i]} betyget {nummer[i]}");
}
Console.ReadLine();

string text = "";

while (text.ToLower() != "exit")
{
    Console.WriteLine("Cities:");
    text = Console.ReadLine();

    Cities.Add(text);
    if (text.ToLower() != "exit")
    {
        Console.WriteLine("Added!");
    }
}

foreach (string city in Cities)
{
    Console.WriteLine(city);

}

Console.ReadLine();