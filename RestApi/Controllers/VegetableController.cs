using Microsoft.AspNetCore.Mvc;
using RestApi.Models;
using RestApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    public class VegetableController : BaseItemController<Vegetable>
    {
        public VegetableController(IItemService<Vegetable> itemService) : base(itemService)
        {
        }
    }
}
