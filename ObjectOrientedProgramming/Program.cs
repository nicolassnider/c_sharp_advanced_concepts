
using ObjectOrientedProgramming.Business;

Beer erdingerBeer = new Beer("Erdinger", 3.50M, 4, 10);
var delirium = new ExpiringBeer("Delirium", 4.00M, 5, 4, DateTime.Now.AddDays(30));
delirium.GetInfo();
delirium.GetInfo("a");
Console.WriteLine(erdingerBeer.GetInfo());

Drink drink = new Wine(20);
Drink anotherDrink = new Beer("Heineken", 2.50M, 4, 15);


SendSome(erdingerBeer);

void Show(Drink drink) => Console.WriteLine(drink.GetCategory());

ISalable[] concepts = new ISalable[] { erdingerBeer, delirium };


void SendSome(ISend some)
{
    some.Send();
}

var intElements = new Collection<int>(4);
var stringElements = new Collection<string>(4);

intElements.Add(1);
intElements.Add(2);
intElements.Add(3);
intElements.Add(4);
intElements.Add(5);
stringElements.Add("a");
stringElements.Add("b");
stringElements.Add("c");
stringElements.Add("d");
stringElements.Add("e");
stringElements.Add("f");
stringElements.Add("g");


var elems = intElements.Get();
Console.WriteLine(Beer.QuantityObjects);
Console.Read();

