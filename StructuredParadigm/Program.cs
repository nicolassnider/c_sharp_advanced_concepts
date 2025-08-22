
int limit = 10;
var beers = new string[limit];
int iBeers = 0;
int op = 0;

do
{

    ShowMenu();
    op = int.Parse(Console.ReadLine() ?? "0");

    switch (op)
    {
        case 1:
            if (iBeers < limit)
            {
                Console.Clear();
                Console.Write("Enter beer name: ");
                string beerName = Console.ReadLine() ?? "Unknown";
                beers[iBeers] = beerName;
                iBeers++;
            }
            else
            {
                Console.WriteLine("Beer list is full.");
            }
            break;

        case 2:
            ShowBeers(beers, iBeers);
            break;
        case 3:
            Console.WriteLine("Exiting the program.");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

}
while (op != 3);

void ShowMenu()
{
    Console.WriteLine("Options");
    Console.WriteLine("1. Add Beer");
    Console.WriteLine("2. Show Beers");
    Console.WriteLine("3. Exit");
}

void ShowBeers(string[] beers, int count)
{
    Console.Clear();
    if (count == 0)
    {
        Console.WriteLine("No beers added yet.");
        return;
    }
    Console.WriteLine("List of Beers:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{i + 1}. {beers[i]}");
    }
    Console.WriteLine();
}