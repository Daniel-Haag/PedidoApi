using MediatR;
using PedidoApi.Models;

namespace PedidoApi.Requests
{
    public class ObterPedidosQuery : IRequest<List<Pedido>> { }
    
}
