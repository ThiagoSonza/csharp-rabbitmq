namespace Thiagosza.RabbitMq.Worker.Configurations;

public class RabbitConfiguration
{
    public string HostName { get; set; } = string.Empty;
    public int Port { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public RabbitConfigurationQueues Queues { get; set; } = default!;
}

public class RabbitConfigurationQueues
{
    public string QueueToProducer { get; set; } = string.Empty;
    public string QueueToConsumer { get; set; } = string.Empty;

}
