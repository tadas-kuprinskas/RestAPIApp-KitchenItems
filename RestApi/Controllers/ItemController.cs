using Microsoft.AspNetCore.Mvc;
using RestApi.Models;
using RestApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseItemController<T> : Controller where T : Item
    {
        private readonly IItemService<T> _itemService;

        public BaseItemController(IItemService<T> itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]
        public void Create(T t)
        {
            _itemService.Create(t);
        }

        [HttpDelete("{id}")]
        public void DeleteById(int id)
        {
            _itemService.DeleteById(id);
        }

        [HttpGet]
        public List<T> GetAll()
        {
            return _itemService.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {           
            return _itemService.GetById(id);
        }

        [HttpPut]
        public void Update(int id, T t)
        {
            _itemService.Update(id, t);
        }

    }
}
