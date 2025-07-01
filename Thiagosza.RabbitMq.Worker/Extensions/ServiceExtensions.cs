using Thiagosza.RabbitMq.Core.Extensions;
using Thiagosza.RabbitMq.Worker.Configurations;
using Thiagosza.RabbitMq.Worker.Consumers;

namespace Thiagosza.RabbitMq.Worker.Extensions;

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
        });

        return services;
    }
}
