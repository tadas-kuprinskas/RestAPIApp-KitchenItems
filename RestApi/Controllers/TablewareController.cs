using Microsoft.AspNetCore.Mvc;
using RestApi.Data;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TablewareController : Controller
    {
        private readonly DataService _dataService;

        public TablewareController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public List<Tableware> GetAll()
        {
            return _dataService.TablewareItems;
        }

        [HttpGet("{id}")]
        public Tableware GetById(int id)
        {
            var tablewareItem = _dataService.TablewareItems.FirstOrDefault(i => i.Id == id);

            if (tablewareItem == null)
            {
                throw new KeyNotFoundException();
            }

            return tablewareItem;
        }

        [HttpDelete("{id}")]
        public void DeleteById(int id)
        {
            var tablewareItem = _dataService.TablewareItems.FirstOrDefault(i => i.Id == id);
            
            if (tablewareItem == null)
            {
                throw new KeyNotFoundException();
            }
            _dataService.TablewareItems.Remove(tablewareItem);
        }

        [HttpPost]
        public void Create(Tableware tablewareItem)
        {
            _dataService.TablewareItems.Add(tablewareItem);
        }

        [HttpPut]
        public void Update(Tableware item)
        {
            var tablewareItemToReplace = _dataService.TablewareItems.FirstOrDefault(i => i.Id == item.Id);

            if (tablewareItemToReplace == null)
            {
                throw new KeyNotFoundException();
            }
            _dataService.TablewareItems[item.Id] = item;
        }







        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
