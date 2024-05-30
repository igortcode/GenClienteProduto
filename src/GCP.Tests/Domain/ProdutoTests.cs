namespace GCP.Tests.Domain
{
    public class ProdutoTests
    {
        [Fact(DisplayName = "Criar objeto Produto com estado válido")]
        public void CriarProduto_ComParametrosValidos_ObjetoComEstadoValido()
        {
            var action = () => new Produto("Teste", "PTeste123", "Descricao", 123.12m, 99.99m);

            action.Should().NotThrow<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Produto com nome inválido")]
        public void CriarProduto_ComNomeInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new Produto("", "PTeste123", "Descricao", 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Produto(new string('a', 201), "PTeste123", "Descricao", 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Produto(null, "PTeste123", "Descricao", 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Produto com Código inválido")]
        public void CriarProduto_ComCodigoInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new Produto("Teste", "", "Descricao", 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Produto("Teste", new string('a', 201), "Descricao", 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Produto("Teste", null, "Descricao", 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Produto com Descrição inválida")]
        public void CriarProduto_ComDescricaoInvalida_ObjetoComEstadoInvalido()
        {
            var action = () => new Produto("Teste", "PTeste123", "", 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Produto("Teste", "PTeste123", new string('a', 1001), 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Produto("Teste", "PTeste123", null, 123.12m, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Produto com Preço inválido")]
        public void CriarProduto_ComPrecoInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new Produto("Teste", "PTeste123", "Descricao", 0, 99.99m);

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Produto com Quantidade inválida")]
        public void CriarProduto_ComQuantidadeInvalida_ObjetoComEstadoInvalido()
        {
            var action = () => new Produto("Teste", "PTeste123", "Descricao", 123.12m, 0);

            action.Should().Throw<DomainExceptionValidate>();
        }
    }
}
