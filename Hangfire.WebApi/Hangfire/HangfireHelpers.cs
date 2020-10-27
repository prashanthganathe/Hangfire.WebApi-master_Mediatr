using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.WebApi.Hangfire
{
    public static class HangfireHelpers
    {
        public static IMediator Mediator { private get; set; }

        public static void Send(IRequest command)
        {
            Mediator.Send(command);
        }
    }
}
