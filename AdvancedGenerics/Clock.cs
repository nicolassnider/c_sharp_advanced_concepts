namespace AdvancedGenerics
{
    public class Clock
    {
        private DateTime _date;
        public DateTime Date => _date;

        public Clock()
        {
            _date = DateTime.Now;
        }
    }
}
