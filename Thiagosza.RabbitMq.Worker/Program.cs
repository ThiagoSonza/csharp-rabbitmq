using Thiagosza.RabbitMq.Worker.Extensions;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddRabbitMq(builder.Configuration);

var host = builder.Build();
host.Run();
