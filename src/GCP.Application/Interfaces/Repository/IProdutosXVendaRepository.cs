using GCP.Core.Entities;
using System.Data;

namespace GCP.App.Interfaces.Repository
{
    public interface IProdutosXVendaRepository
    {
        int Add(ProdutosXVenda produtosXVenda, IDbTransaction transaction = null);
        void AddRange(IEnumerable<ProdutosXVenda> produtosXVenda, IDbTransaction transaction = null);
        int Remove(int idProduto, int idVenda);
        ProdutosXVenda GetById(int id);
        IEnumerable<ProdutosXVenda> GetAll(int idVenda);
        void DesabilitarRestricoes();
    }
}
