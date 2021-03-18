using Microsoft.AspNetCore.Mvc;
using RestApi.Data;
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
    public class TablewareController : BaseItemController<Tableware>
    {
        public TablewareController(IItemService<Tableware> itemService) : base(itemService)
        {
        }
    }
}
