List<string> leksaker = ["Bil", "Lego", "Pussel", "Cykel", "Boll"];
List<string> Namn = ["Rasmus", "Simon", "Wiggo", "Elias", "Bullen"];
List<int> nummer = [1, 4, 8, 5, 2];
List<string> Cities = [];



for (int i = 0; i < leksaker.Count; i++)
{
    Console.WriteLine($"{Namn[i]} ger {leksaker[i]} betyget {nummer[i]}");
}
Console.ReadLine();

while