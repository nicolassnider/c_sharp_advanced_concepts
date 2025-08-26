using AdvancedFunctionalProgramming.Classes;
using AdvancedFunctionalProgramming.Extensions;

var sum = Closure.SumClosure();
Console.WriteLine(sum(1, 2));

var fn = Closure.DelayExecutor(2000, () => Console.WriteLine("Delayed Execution"));
fn();

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var stringNumbers = numbers.Map<int, string>((item) => $"number is {item}");

foreach (var item in stringNumbers)
{
    Console.WriteLine(item);
}

var oddNumbers = numbers.Filter(item => item % 2 != 0);
foreach (var item in oddNumbers)
{
    Console.WriteLine(item);
}

var sumOfNumbers = numbers.Reduce((acc, item) => acc + item, 0);
Console.WriteLine($"Sum of numbers: {sumOfNumbers}");


//composition
Func<double, double, double> add = (a, b) => a + b;
Func<double, double> mulx2 = a => a * 2;


Func<double, double> addThenMul = a => mulx2(add(a, 10));

Func<string, string> removeSpace = (s) => s.Replace(" ", "");
Func<string, string> firstCapitalLetter = (s) => char.ToUpper(s[0]) + s.Substring(1);
Func<string, string> removeNumbers = (s) => new string(s.Where(c => !char.IsDigit(c)).ToArray());

string textToClean = "  hello 123 world  ";
string cleanText = Functions.PipeStrings(textToClean, removeSpace, firstCapitalLetter, removeNumbers);
string cleanText2 = Functions.Pipe<string>(textToClean, removeSpace, firstCapitalLetter, removeNumbers);

var numbersXPipe = Functions.Pipe(numbers,
    lst => lst.Map(e => e * 2),
    lst => lst.Map(e => e - 1));
Console.WriteLine(cleanText);
Console.WriteLine(cleanText2);
foreach (var item in numbersXPipe)
{
    Console.WriteLine(item);
}

var numberXPipe = numbers.P(lst => lst.Map(e => e * 2))
    .P(lst => lst.Map(e => e - 1))
    .P(lst => lst.Reduce((ac, item) => ac + item, 0));

Console.WriteLine(numberXPipe);


Func<string, Func<string, string>> Concat()
{
    return a => b => a + " " + b;
}

var concat = Concat();
var concatWithHello = concat("Hello");
Console.WriteLine(concatWithHello("Pedro"));
Console.WriteLine(concat("Hello")("Pedro"));

Func<decimal, Func<decimal, Func<decimal, decimal>>> calculateTotal =
    basePrice => tax => discount => (basePrice + (basePrice * tax) - discount);

Console.WriteLine(calculateTotal(100)(0.15m)(20));

//Memoization
var pow2 = Memoization.Pow(2);
Console.WriteLine(pow2(3));
Console.WriteLine(pow2(5));
Console.WriteLine(pow2(6));
Console.WriteLine(pow2(7));
Console.WriteLine(pow2(3));
Console.WriteLine(pow2(5));
Console.WriteLine(pow2(6));
Console.WriteLine(pow2(7));

var getUrl = Memoization.GetUrl("https://jsonplaceholder.typicode.com/posts");
var result = await getUrl(1);
Console.WriteLine(result);
Console.WriteLine(
    await getUrl(1));
Console.WriteLine(
    await getUrl(2));

var mulx5 = (double x) => x * 5;
var mem = Memoization.Mem(mulx5);

var getUrlAsync = async (string url) =>
{
    using (var client = new HttpClient())
    {
        var response = await client.GetAsync(url);
        var responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }
};

var memAsync = Memoization.MemAsync(getUrlAsync);
var response1 = await memAsync("https://jsonplaceholder.typicode.com/posts/1");
Console.WriteLine(response1);


// functor
var identity = new Identity<int>(55);
var newIdentity = identity.Map<string>(x => "Wrapped number: " + x.ToString());

var beerPrice = new Identity<double>(100);
var beerTax = 0.1;
var beerDiscount = 15;
var totalBeerPrice = beerPrice
    .Map(price => price + (price * beerTax))
    .Map(priceWithTax => priceWithTax - beerDiscount)
    .Map(x => "total is: " + x.ToString());

var numberMbFncr = MaybeFunctor<int>
    .Some(5)
    .Map(x => x * 2)
    .Map(x => $"number is {x.ToString()} ");

// monad
MaybeMonad<int> Div(int num, int div)
{
    if (div == 0)
    {
        return MaybeMonad<int>.None();
    }
    return MaybeMonad<int>.Some(num / div);
}

MaybeMonad<int> Add(int num, int num2)
{
    if (num < 0 || num2 < 0)
    {
        return MaybeMonad<int>.None();
    }
    return MaybeMonad<int>.Some(num + num2);
}

var maybeMonad = MaybeMonad<int>
    .Some(80)
    .Bind(x => Div(x, 2))
    .Bind(x => Add(x, 5))
    .Bind(x => Div(x, 0))
    .Bind(x => Add(x, 10));

var maybeMonadBeer = Search(1)
    .Bind(beer => ValidateName(beer.Name))
    .Map(name => $"Beer name is {name}");

MaybeMonad<Beer> Search(int id)
{
    if (id == 1)
    {
        return MaybeMonad<Beer>.Some(new Beer { Id = 1, Name = "Corona" });
    }
    return MaybeMonad<Beer>.None();
}
MaybeMonad<string> ValidateName(string name)
{
    if (string.IsNullOrEmpty(name))
    {
        return MaybeMonad<string>.None();
    }
    return MaybeMonad<string>.Some(name);
}
Console.ReadKey();
