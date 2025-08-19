using Thiagosza.RabbitMq.Core.Extensions;
using Thiagosza.RabbitMq.WebApi.Configurations;
using Thiagosza.RabbitMq.WebApi.Consumers;
using Thiagosza.RabbitMq.WebApi.Consumers.Messages;

namespace Thiagosza.RabbitMq.WebApi.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRabbitMq(this IServiceCollection services, IConfiguration configuration)
    {
        var config = configuration.GetSection("RabbitMq").Get<RabbitConfiguration>()!;

        services.AddRabbitMqMessaging(configure =>
        {
            configure.Host(new Uri($"amqp://{config.HostName}"), config.Port, h =>
            {
                h.UserName = config.UserName;
                h.Password = config.Password;
            });

            configure.AddConsumer<EventConsumer>(config.Queues.QueueToConsumer);
            configure.AddProducer<EventMessage>(config.Queues.QueueToProducer);
        });

        return services;
    }
}
