using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Catalog.Controllers
{
    // GET /items

    [ApiController] 
    [Route("items")]
    
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }

        // Get /items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }
        
        // Get /items/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id) // ActionResult allows you to return more than one type for this method
        {
            var item = repository.GetItem(id);
 
            if (item is null)
            {
                return NotFound();
            }
            return item;
        }
    }

}