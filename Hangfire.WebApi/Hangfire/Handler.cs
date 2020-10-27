using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hangfire.WebApi.Hangfire
{
    public class Handler : IRequestHandler<RequestCommand, Unit>
    {
        //public Unit Handle(Command command)
        //{
        //    Console.WriteLine($"{command.Message} from Thread {Thread.CurrentThread.ManagedThreadId}");
        //    return Unit.Value;
        //}

        //public Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        //{
        //    Console.WriteLine($"{request.Message} from Thread {Thread.CurrentThread.ManagedThreadId}");
        //    return await Unit.Value;
        //}
        public async Task<Unit> Handle(RequestCommand request, CancellationToken cancellationToken)
        {          
                Console.WriteLine($"{request.Message} from Thread {Thread.CurrentThread.ManagedThreadId}");
                return Unit.Value;
            
        }
    }
}
