using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaAPI.Models;
using LambdaAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LambdaAPI.Controllers
{
    [Route("v1/items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsController(IItemsRepository itemsRepository)
        {
            _itemsRepository= itemsRepository;
        }
        
        [HttpGet]
        public  IActionResult GetItems()
        {
            var result = _itemsRepository.GetItems();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItem([FromBody] Item item)
        {
            var result = _itemsRepository.AddItem(item);

            return Created("",item);
        }

        [HttpDelete]
        public IActionResult DeleteItem([FromBody] Item item)
        {
            var result = _itemsRepository.RemoveItem(item);

            return Ok(result);
        }

    }
}