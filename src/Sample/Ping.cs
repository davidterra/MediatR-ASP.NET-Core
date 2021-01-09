using MediatR;

namespace Sample
{
    public class Ping : IRequest<string> 
    {
        public Ping(string message) => Message = message;               
        public string Message { get; set; }
    }
}