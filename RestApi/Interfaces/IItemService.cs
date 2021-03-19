using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Interfaces
{
    public interface IItemService<T> where T : Item
    {
         List<T> Items { get; set; }
         List<T> GetAll();
         T GetById(int id);
         void DeleteById(int id);
         void Create(T t);
         void Update(int id, T t);
    }
}
