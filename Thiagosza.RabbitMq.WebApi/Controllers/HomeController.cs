using Microsoft.AspNetCore.Mvc;
using Thiagosza.RabbitMq.Core.Interfaces;
using Thiagosza.RabbitMq.WebApi.Consumers.Messages;

namespace Thiagosza.RabbitMq.WebApi.Controllers;

public class HomeController : Controller
{
    [HttpPost("publish-message")]
    public async Task<IActionResult> PublicarEvento([FromServices] IRabbitMqPublisher publisher)
    {
        var evento = new EventMessage(Texto: "Message published sucefully!");
        await publisher.PublishAsync(evento);
        return Ok("Message published sucefully!");
    }
}
