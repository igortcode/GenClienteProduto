using GCP.App.DTO.Clientes;
using GCP.Core.Enums;

namespace GCP.App.DTO.Venda
{
    public class VendaDTO
    {
        public int? Id { get; set; }
        public ClienteDTO ClienteDTO { get; set; }
        public IList<ProdutoXVendaDTO> Produtos { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
    }
}
