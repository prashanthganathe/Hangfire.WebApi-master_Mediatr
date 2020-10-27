using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.WebApi.Hangfire
{
    public class RequestCommand : IRequest
    {
        public string Message { get; set; }
    }
}
