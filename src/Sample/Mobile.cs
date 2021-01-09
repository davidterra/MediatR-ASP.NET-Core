using MediatR;

namespace Sample
{
    public class Mobile : INotification
    {
        public Mobile(string number) => Number = number;
        public string Number { get; set; } 
    }
}