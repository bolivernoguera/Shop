using Shops.Domain;
using Shops.Infrastructure;

namespace Shops.Aplication
{
    public static class ShopFactory
    {
        public static IShop GetShopProvider(ShopProvider shopProvider)
        {
            if (shopProvider == ShopProvider.XkNo)
            {
                return new XkNoShop();
            }
            else
            {
                return new StarbucksShop();
            }
        }
    }
}
