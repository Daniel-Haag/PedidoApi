using MediatR;
using PedidoApi.Models;

namespace PedidoApi.Requests
{
    public class CriarPedidoCommand : IRequest<Pedido>
    {
        public string Cliente { get; set; } = string.Empty;
        public decimal Valor { get; set; }
    }
}
