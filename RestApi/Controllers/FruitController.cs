using Microsoft.AspNetCore.Mvc;
using RestApi.Interfaces;
using RestApi.Models;
using RestApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    public class FruitController : BaseItemController<Fruit>
    {
        public FruitController(IItemService<Fruit> itemService) : base(itemService)
        {
        }
    }
}
