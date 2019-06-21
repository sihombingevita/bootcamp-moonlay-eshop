using ExtCore.Data.Abstractions;
using Inventories.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Inventories.Controllers
{
    public class InventoryController : Barebone.Controllers.ControllerBase
    {
        private readonly IProductRepository _repoProduct;

        public InventoryController(IStorage storage) : base(storage)
        {
            _repoProduct = this.Storage.GetRepository<IProductRepository>();
        }

        public ActionResult Index()
        {
            var products = _repoProduct.All();
            return Ok(products);
        } 
    }
}
