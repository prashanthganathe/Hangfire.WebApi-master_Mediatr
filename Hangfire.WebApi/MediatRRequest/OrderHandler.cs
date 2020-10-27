using Hangfire.WebApi.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hangfire.WebApi.MediatRRequest
{
    public class OrderHandler : IRequestHandler<OrderRequestModel, OrderResponseModel>
    {
        public async Task<OrderResponseModel> Handle(OrderRequestModel request, CancellationToken cancellationToken)
        {
            var bookDetails = new OrderResponseModel();
            // Business logic goes here
            // Read from ReadDB
            return bookDetails;
        }
    }
}
