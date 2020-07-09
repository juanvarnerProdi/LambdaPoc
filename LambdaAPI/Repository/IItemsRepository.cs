using LambdaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaAPI.Repository
{
    public interface IItemsRepository
    {
        List<Item> GetItems();
        bool AddItem(Item item);
        bool RemoveItem(Item item);
    }
}
