namespace GCP.Tests.Domain
{
    public class ProdutoXVendaTests
    {
        [Fact(DisplayName = "Criar objeto ProdutoXVenda com estado válido")]
        public void CriarProdutoXVenda_ComParametrosValidos_ObjetoComEstadoValido()
        {
            var action = () => new ProdutosXVenda(1, 1, 123.12m, 99.99m);

            action.Should().NotThrow<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto ProdutoXVenda com identificador da venda inválido")]
        public void CriarProdutoXVenda_IdVendaInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new ProdutosXVenda(0, 1, 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto ProdutoXVenda com identificador do produto inválido")]
        public void CriarProdutoXVenda_IdProdutoInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new ProdutosXVenda(1, 0, 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto ProdutoXVenda com Preço do produto inválido")]
        public void CriarProdutoXVenda_PrecoInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new ProdutosXVenda(1, 1, 0, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto ProdutoXVenda com Quantidade do produto inválido")]
        public void CriarProdutoXVenda_QuantidadeInvalida_ObjetoComEstadoInvalido()
        {
            var action = () => new ProdutosXVenda(1, 1, 123.12m, 0);

            action.Should().Throw<DomainExceptionValidate>();
        }
    }
}
