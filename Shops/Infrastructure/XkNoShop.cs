using Shops.Aplication;
using Shops.Domain;

namespace Shops.Infrastructure
{
    public class XkNoShop : IShop
    {
        public ShopProvider ShopProvider => ShopProvider.XkNo;

        public decimal BuyCoffe()
        {
            return 1;
        }
    }
}
