using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Services
{
    public class ItemService<T> : IItemService<T> where T : Item
    {
        public List<T> Items { get; set; } = new();

        public void Create(T t)
        {
            Items.Add(t);
        }

        public void DeleteById(int id)
        {
            var kitchenItem = Items.FirstOrDefault(i => i.Id == id);

            if (kitchenItem == null)
            {
                throw new KeyNotFoundException();
            }
            Items.Remove(kitchenItem);
        }

        public List<T> GetAll()
        {
            return Items;
        }

        public T GetById(int id)
        {
            var kitchenItem = Items.FirstOrDefault(i => i.Id == id);

            if (kitchenItem == null)
            {
                throw new KeyNotFoundException();
            }            

            return kitchenItem;
        }

        public void Update(int id, T t)
        {
            var kitchenItemToReplace = Items.FirstOrDefault(i => i.Id == id);

            if (kitchenItemToReplace == null)
            {
                throw new KeyNotFoundException();
            }
            kitchenItemToReplace.Id = t.Id;
        }
    }

}
