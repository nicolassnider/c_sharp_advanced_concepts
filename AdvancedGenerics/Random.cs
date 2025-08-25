namespace AdvancedGenerics
{
    public class Randoms
    {
        private double _number;
        public double Number => _number;
        public Randoms()
        {
            _number = new Random().NextDouble();
        }
    }
}
