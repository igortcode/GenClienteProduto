using GCP.App.Interfaces.Repository;
using GCP.Repository.Repository;
using System.Transactions;

namespace GCP.Tests.Repository
{
    public class ProdutoRepositoryTest
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoRepositoryTest()
        {
            _produtoRepository = new ProdutoRepository(Connection.GetDbSettings());
        }

        [Fact(DisplayName = "Inserir Produto com estado válido")]
        public void InserirProduto_ComParametrosValidos_OperacaoValida()
        {
            using var transaction = new TransactionScope();

            var action = () => _produtoRepository.Add(GetProduto());

            action.Should().NotThrow<Exception>();
        }

        [Fact(DisplayName = "Atualizar Produto com estado válido")]
        public void AtualizarProduto_ComParametrosValidos_OperacaoValida()
        {
            using var transaction = new TransactionScope();

            var id = _produtoRepository.Add(GetProduto());

            var produto = _produtoRepository.GetById(id);

            produto.Atualizar("Teste", "Atualizar", "Descricao", 123.12m, 99.99m);

            var action = () => _produtoRepository.Update(produto);

            action.Should().NotThrow<Exception>();

            produto = _produtoRepository.GetById(id);

            produto.Codigo.Should().BeEquivalentTo("Atualizar");
        }

        private Produto GetProduto()
        {
            return new Produto("Teste", "PTeste123", "Descricao", 123.12m, 99.99m);
        }
    }
}
