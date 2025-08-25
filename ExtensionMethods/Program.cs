using ExtensionMethods.Classes;
using ExtensionMethods.Extensions;

int number = 10;
int numberx2 = number.X2();
int numberx5 = number.Mul(5);

var sale = new Sale(100);
Console.WriteLine(sale.GetInfo());

var intList = new List<int> { 1, 2, 3, 4, 5 };
var namesList = new List<string> { "Alice", "Bob", "Charlie" };

Console.WriteLine(3.Exists(intList));
Console.WriteLine("Alice".Exists(namesList));

var wineExt = new Wine { Quantity = 1 };
var beerExt = new Beer { Quantity = 0.5M };

Console.WriteLine(wineExt.GetDescription());
Console.WriteLine(beerExt.GetDescription());

beerExt.SetName("Lager").SetBrand("Heineken").SetQuantity(0.75M);

Console.ReadKey();
