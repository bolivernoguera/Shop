using Shops.Aplication;
using Shops.Domain;

namespace Shops.Infrastructure
{
    public class StarbucksShop : IShop
    {
        public ShopProvider ShopProvider => ShopProvider.StarBucks;

        public decimal BuyCoffe()
        {
            return 2;
        }
    }
}
