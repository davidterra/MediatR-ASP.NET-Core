using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Sample
{
    public class MobileHandler : INotificationHandler<Mobile>
    {
        public Task Handle(Mobile notification, CancellationToken cancellationToken)
        {
            // Código para enviar uma mensagem para o número enviado no objeto Mobile.
            // ...
            Debug.WriteLine(notification.Number);

            return Task.CompletedTask;
        }
    }
}