using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaShoppingListWebAPI.Services;
using LambdaShoppingListWebAPI.Models;

namespace LambdaShoppingListWebAPI.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItemsFromShoppingList();

        void AddItemsToShoppingList(ShoppingListModel shoppingList);

        void RemoveItem(string shoppingListName);
    }
}
