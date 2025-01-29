using MediatR;
using Microsoft.EntityFrameworkCore;
using PedidoApi.Data;
using PedidoApi.Models;
using PedidoApi.Requests;

namespace PedidoApi.Handlers;

public class ObterPedidosHandler : IRequestHandler<ObterPedidosQuery, List<Pedido>>
{
    private readonly AppDbContext _context;

    public ObterPedidosHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Pedido>> Handle(ObterPedidosQuery request, CancellationToken cancellationToken)
    {
        return await _context.Pedidos.ToListAsync();
    }
}
