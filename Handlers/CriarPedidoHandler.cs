using MediatR;
using PedidoApi.Data;
using PedidoApi.Models;
using PedidoApi.Requests;

namespace PedidoApi.Handlers
{
    public class CriarPedidoHandler : IRequestHandler<CriarPedidoCommand, Pedido>
    {
        private readonly AppDbContext _context;

        public CriarPedidoHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Pedido> Handle(CriarPedidoCommand request, CancellationToken cancellationToken)
        {
            var pedido = new Pedido { Cliente = request.Cliente, Valor = request.Valor };

            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();

            return pedido;
        }
    }
}
