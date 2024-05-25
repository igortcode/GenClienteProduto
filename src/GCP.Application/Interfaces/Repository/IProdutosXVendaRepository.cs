using GCP.Core.Entities;

namespace GCP.Application.Interfaces.Repository
{
    public interface IProdutosXVendaRepository
    {
        int Add(ProdutosXVenda produtosXVenda);
        int Remove(int idProduto, int idVenda);
        ProdutosXVenda? GetById(int id);
        IEnumerable<ProdutosXVenda> GetAll(int idVenda);
    }
}
