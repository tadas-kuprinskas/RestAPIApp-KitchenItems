using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.Data
{
    public class DataService
    {
        public List<Tableware> TablewareItems { get; set; }
        public List<Fruit> Fruits { get; set; }
        public List<Vegetable> Vegetables { get; set; }


        public DataService()
        {
            TablewareItems = new List<Tableware>();
        }
    }
}
