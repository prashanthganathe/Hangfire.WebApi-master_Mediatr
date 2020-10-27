using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.WebApi.MediatRRequest
{
    public class SyncRequestHandler: RequestHandler<Ping,string>
    {
        protected override string Handle(Ping request)
        {
            return "Pong";
        }
    }
}
