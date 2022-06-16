using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Catalog.Controllers
{
    // GET /items

    [ApiController] 
    [Route("items")]
    
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsController()
        {
            repository = new InMemItemsRepository();
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