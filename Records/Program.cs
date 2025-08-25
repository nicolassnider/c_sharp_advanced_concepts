using Records.Records;

var beerRecord = new Beer("Duvel", 8.5, new Brand("brand"));
//beer.Name = "Duvel Tripel Hop"; // This line will cause a compile-time error because 'Name' is read-only
var (name, alcohol, brand) = beerRecord;

var beerRecordTwo = new Beer("asdf", 7, new Brand("brand"));
Console.WriteLine(beerRecord == beerRecordTwo);
var beerRecordThree = new Beer("Duvel", 8.5, new Brand("brand"));

Console.WriteLine(beerRecord == beerRecordThree);
var beerRecordFour = new Beer("Duvel", 8.5, new Brand("asdf"));
Console.WriteLine(beerRecord == beerRecordFour);

var country = new Country("Mexico") { Population = 120000000 };
country.Population = 130000000;
//country.name = "USA"; // This line will cause a compile-time error because 'name' is read-only

var beerRecordFive = beerRecord with { Name = "Duvel Tripel Hop" };

Console.ReadKey();
