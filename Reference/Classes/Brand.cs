namespace Reference.Classes
{
    public class Brand
    {
        public string Name { get; }
        public Brand(string name, List<string> beers)
        {
            Name = name;
            Beers = beers;
        }

        public IReadOnlyList<string> Beers { get; }

        public Brand With(string? name = null, List<string> beers = null)
        {
            return new Brand(name ?? this.Name, beers ?? this.Beers.ToList());
        }
    }


}
