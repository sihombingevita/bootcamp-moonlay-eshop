using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Inventories.Controllers
{
    public class InventoryController : Barebone.Controllers.ControllerBase
    {
        public InventoryController(IStorage storage) : base(storage)
        {
        }

        public ActionResult Index()
        {
            return View();
        } 
    }
}
