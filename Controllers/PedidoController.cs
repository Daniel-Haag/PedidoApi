using MediatR;
using Microsoft.AspNetCore.Mvc;
using PedidoApi.Models;
using PedidoApi.Requests;

namespace PedidoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedidoController : ControllerBase
{
    private readonly IMediator _mediator;

    public PedidoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<Pedido>> CriarPedido([FromBody] CriarPedidoCommand command)
    {
        var pedido = await _mediator.Send(command);
        return CreatedAtAction(nameof(CriarPedido), new { id = pedido.Id }, pedido);
    }

    [HttpGet]
    public async Task<ActionResult<List<Pedido>>> ObterPedidos()
    {
        var pedidos = await _mediator.Send(new ObterPedidosQuery());
        return Ok(pedidos);
    }
}
