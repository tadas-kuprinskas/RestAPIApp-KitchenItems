using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Services
{
    public interface IItemService<T> where T : Item
    {
        public List<T> Items { get; set; }
        public List<T> GetAll();
        public T GetById(int id);
        public void DeleteById(int id);
        public void Create(T t);
        public void Update(T t);
    }
}
