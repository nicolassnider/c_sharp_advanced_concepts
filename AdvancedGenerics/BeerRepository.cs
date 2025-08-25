using AdvancedGenerics.Interfaces;

namespace AdvancedGenerics
{
    internal class BeerRepository : IRepository<string>
    {
        private string[] _beers;
        private int _index;
        private const int QUANITY = 10;

        public BeerRepository()
        {
            _beers = new string[QUANITY];
            _index = 0;
        }

        public void Add(string model)
        {
            if (_index < QUANITY)
            {
                _beers[_index++] = model;
            }

        }

        public IEnumerable<string> GetAll()
        {
            return _beers;
        }
    }
}
