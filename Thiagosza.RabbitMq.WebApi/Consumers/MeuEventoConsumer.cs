using Thiagosza.RabbitMq.Core.Interfaces;
using Thiagosza.RabbitMq.WebApi.Consumers.Messages;

namespace Thiagosza.RabbitMq.WebApi.Consumers;

public class EventConsumer(ILogger<EventConsumer> logger) : IMessageHandler<EventMessage>
{
    public Task HandleAsync(EventMessage message, CancellationToken cancellationToken)
    {
        logger.LogInformation("Mensagem recebida: {Texto}", message.Texto);
        return Task.CompletedTask;
    }
}
