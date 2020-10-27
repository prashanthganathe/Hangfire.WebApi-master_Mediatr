using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.WebApi.Model
{
    public class OrderResponseModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
