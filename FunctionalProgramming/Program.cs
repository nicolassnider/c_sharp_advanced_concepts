using ObjectOrientedProgramming.Business;

Console.WriteLine(TomorrowNoPureFunction());

var beer = new Beer("heineken", 1, 1, 1);
Console.WriteLine(ToUpper(beer).Name);
Console.WriteLine(beer.Name);

var newBeer = new Beer("heineken", 1, 1, 1);
Console.WriteLine(ToUpperPure(beer));
Console.WriteLine(newBeer.Name);

Action<string> show = Console.WriteLine;
show("Hello from Action");

Action<string> hi = name => Console.WriteLine($"Hi {name}");
hi("John");
Action<int, int> add = (a, b) => show((a + b).ToString());

// func
Func<int, int, int> mul = (a, b) => a * b;

show(mul(2, 3).ToString());

// superior order
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenNumber = Filter(numbers, number => number % 2 == 0);
var divisibleByFive = Filter(numbers, number => number % 5 == 0);
List<int> Filter(List<int> list, Func<int, bool> condition)
{
    var resultList = new List<int>();
    foreach (var item in list)
    {
        if (condition(item))
        {
            resultList.Add(item);
        }
    }
    return resultList;
}
;

// predicate
Predicate<int> isEven = number => number % 2 == 0;
show(isEven(4).ToString());

// no pure section
DateTime TomorrowNoPureFunction()
{
    return DateTime.Now.AddDays(1);
}

Beer ToUpper(Beer beer)
{
    beer.Name = beer.Name.ToUpper();
    return beer;
}

// pure section
DateTime tomorrowPureFunction(DateTime date)
{
    return date.AddDays(1);
}

Beer ToUpperPure(Beer beer)
{
    var beerTwo = new Beer(beer.Name, beer.Price, beer.Alcohol, beer.Quantity);
    beerTwo.Name = beerTwo.Name.ToUpper();
    return beerTwo;
}

// first class functions
var t = tomorrowPureFunction(DateTime.Now);



Console.ReadKey();
