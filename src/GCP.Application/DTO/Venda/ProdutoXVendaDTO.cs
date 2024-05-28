namespace GCP.App.DTO.Venda
{
    public class ProdutoXVendaDTO
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
