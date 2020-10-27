using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Hangfire.WebApi.MediatRRequest
{
    public class OneWay:IRequest
    {
    }

    public class OneWayHandler : AsyncRequestHandler<OneWay>
    {
        protected override Task Handle(OneWay request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
