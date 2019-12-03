using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LambdaShoppingListWebAPI.Controllers;
using LambdaShoppingListWebAPI.Services;
using LambdaShoppingListWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LambdaShoppingListWebAPI.Controllers
{
    [Route("v1/shoppingList")]
    public class ShoppingListController : Controller
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }

        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var result = _shoppingListService.GetItemsFromShoppingList();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItemToShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.AddItemsToShoppingList(shoppingList);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItemFromShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.RemoveItem(shoppingList.Name);

            return Ok();
        }
    }
}
