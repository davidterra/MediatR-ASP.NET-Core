using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Sample
{
    public class PingHandler : IRequestHandler<Ping, string>
    {
        public Task<string> Handle(Ping request, CancellationToken cancellationToken) 
            => Task.FromResult(request.Message);
    }
}