using GCP.App.DTO.Produtos;
using System.Data;

namespace GCP.App.Interfaces.Services
{
    public interface IProdutoServices
    {
        void Add(ProdutoDTO dto);
        void Update(ProdutoDTO dto);
        IEnumerable<ProdutoDTO> GetAll();
        DataTable GetDataTable();
        IEnumerable<ProdutoDTO> Search(string search);
        ProdutoDTO GetById(int id);
        ProdutoDTO GetByCodigo(string codigo);
        void Remove(int id);
    }
}
