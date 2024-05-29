using GCP.Core.Enums;

namespace GCP.App.DTO.Venda
{
    public class ObterVendaDTO
    {
        public int? Id { get; set; }
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public decimal ValorTotal { get; set; }
        public IList<ProdutoXVendaDTO> Produtos { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
    }
}
