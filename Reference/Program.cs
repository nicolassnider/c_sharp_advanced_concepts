using Reference.Classes;

int num = 1;
Console.WriteLine($"Before: {num}");
change(num);
Console.WriteLine($"After: {num}");


void change(int num2)
{
    Console.WriteLine("begin Change");
    Console.WriteLine($"Before: {num2}");
    num2 = 2;
    Console.WriteLine($"After: {num2}");
    Console.WriteLine("end Change");
}

int numRef = 1;
Console.WriteLine($"Before: {numRef}");
changeRef(ref numRef);
Console.WriteLine($"After: {numRef}");


void changeRef(ref int num2)
{
    Console.WriteLine("begin ChangeRef");
    Console.WriteLine($"Before: {num2}");
    num2 = 2;
    Console.WriteLine($"After: {num2}");
    Console.WriteLine("end ChangeRef");
}

var numberObject = new Number { Num = 1 };
Console.WriteLine($"Before: {numberObject.Num}");
changeObject(numberObject);
Console.WriteLine($"After: {numberObject.Num}");

void changeObject(Number n)
{
    Console.WriteLine("begin ChangeObject");
    Console.WriteLine($"Before: {n.Num}");
    n.Num = 2;
    Console.WriteLine($"After: {n.Num}");
    Console.WriteLine("end ChangeObject");
}

var s = "s";
Console.WriteLine($"s: {s}");
changeString(s);
Console.WriteLine($"s: {s}");


void changeString(string s)
{
    Console.WriteLine("begin ChangeString");
    Console.WriteLine($"s: {s}");
    s = "updated";
    Console.WriteLine($"s: {s}");
    Console.WriteLine("end ChangeString");
}

var calculator = new Calculator(4);
Console.WriteLine($"PI: {Calculator.PI}");
Console.WriteLine($"Value: {calculator.Value}");

var brand = new Brand("BrandName", ["a", "b", "c"]);
var brandName = brand.Name;
//brand.Name = "NewBrandName"; // This line will cause a compile-time error because Name has no setter.


List<string> beers = new List<string>()
{
    "weisen","pils"
};
var brandBeers = new Brand("brnd", beers);

var brand2 = brandBeers.With(name: "newBrand");
var brand3 = brandBeers.With(beers: new List<string> { "new" });

Console.ReadKey();
