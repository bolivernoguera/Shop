using Shops.Domain;

namespace Shops.Aplication
{
    public interface IShop
    {

        public ShopProvider ShopProvider { get; }
        public decimal BuyCoffe();

    }
}
