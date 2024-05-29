namespace GCP.App.DTO.Produtos
{
    public class ProdutoDTO
    {
        public int? Id { get; set; }
        public string Nome { get;  set; }
        public string Codigo { get;  set; }
        public string Descricao { get;  set; }
        public decimal Preco { get;  set; }
        public decimal Quantidade { get;  set; }
    }
}
