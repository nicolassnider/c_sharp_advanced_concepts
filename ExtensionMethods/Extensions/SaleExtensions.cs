using ExtensionMethods.Classes;

namespace ExtensionMethods.Extensions
{
    public static class SaleExtensions
    {
        public static string GetInfo(this Sale sale)
        {
            return $"Sale Amount: {sale.Amount}";
        }
    }
}
