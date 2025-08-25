// See https://aka.ms/new-console-template for more information
using AdvancedGenerics;
using AdvancedGenerics.Interfaces;

Console.WriteLine("Hello, World!");

var boxInt = new Box<int>(123);
boxInt.Set(15);

var boxString = new Box<string>("Hello Generics");
boxString.Set("Updated String");
Console.WriteLine(boxInt.Describe());


var beerRepo = new BeerRepository();
Show(beerRepo);
void Show<T>(IRepository<T> repository)
{
    foreach (var item in repository.GetAll())
    {
        Console.WriteLine(item);
    }
}

var drink = new Drink(5);
var beerClass = new Beer("Lager", 10);
ShowCuantity(drink);
ShowCuantity(beerClass);
void ShowCuantity<T>(T drink) where T : Drink
{
    Console.WriteLine(drink.Quantity);
}

void ShowInfo<T>(T item) where T : IInfo
{
    Console.WriteLine(item.GetInfo());
}

var clocksPool = new ObjectPool<Clock>(3);
var randomsPool = new ObjectPool<Randoms>(2);

while (clocksPool.Count > 0)
{
    var clock = clocksPool.Get();
    Console.WriteLine(clock.Date);
}

void ShowInfoAndQuantity<T>(T eleent) where T : Drink, IInfo
{

}

IEnumerable<Drink> list = new List<Beer>();

IDrinkCreator<Drink> drinkCreator = new IPABeerCreator();
var drink2 = drinkCreator.Create(500);

IShow<Beer> beerShow = new DrinkShow();
beerShow.Show(beerClass);

Operation<int> add = (a, b) => a + b;
Operation<double> adddouble = (a, b) => a * b;
Operation<string> concat = (a, b) => a + b;
delegate T Operation<T>(T a, T b);
