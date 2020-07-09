using LambdaAPI.Data;
using LambdaAPI.Models;
using Renci.SshNet.Security.Cryptography.Ciphers.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaAPI.Repository
{
    public class ItemsRepository: IItemsRepository
    {
        private readonly AppDbContext _db;

        public ItemsRepository(AppDbContext db)
        {
            _db = db;
        }

        public bool AddItem(Item item)
        {
            _db.Add(item);

            var result = _db.SaveChanges();
            return result > 0;
        }

        public List<Item> GetItems()
        {
            return _db.Items.ToList();
        }

        public bool RemoveItem(Item item)
        {
            _db.Remove(item);
            var result = _db.SaveChanges();
            return result > 0;
        }
    }
}
