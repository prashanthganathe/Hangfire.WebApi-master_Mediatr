using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.WebApi.Model
{
    public class OrderRequestModel: IRequest<OrderResponseModel>
    {
        public string Name { get; set; }
    }
}
