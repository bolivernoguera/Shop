using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shops.Aplication;
using Shops.Domain;

namespace Shops.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {

        private readonly ILogger<ShopController> _logger;
        private readonly IShop _shop;

        public ShopController(
            ILogger<ShopController> logger,
            IShop shop)
        {
            _logger = logger;
            _shop = shop;
        }

        [HttpPost]
        [Route("coffe")]
        public ShopResponse BuyCoffe()
        {
            return new ShopResponse()
            {
                Price = _shop.BuyCoffe(),
                ShopProvider = _shop.ShopProvider
            };
        }

        [HttpPost]
        [Route("coffe2")]
        public ShopResponse BuyCoffe2([FromBody]ShopRequest shopRequest)
        {
            var shop = ShopFactory.GetShopProvider(shopRequest.ShopProvider);

            return new ShopResponse()
            {
                Price = shop.BuyCoffe(),
                ShopProvider = shop.ShopProvider
            };
        }
    }
}
