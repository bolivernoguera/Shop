namespace Shops.Domain
{
    public class ShopRequest
    {
        public ShopProvider ShopProvider { get; set; }
    }

    public enum ShopProvider
    {
        XkNo,
        StarBucks
    }
}
