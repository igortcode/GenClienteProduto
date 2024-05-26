using GCP.App.DTO.Produtos;

namespace GCP.App.Interfaces.Services
{
    public interface IProdutoServices
    {
        void Add(ProdutoDTO dto);
        void Update(ProdutoDTO dto);
        IEnumerable<ProdutoDTO> GetAll();
        IEnumerable<ProdutoDTO> Search(string search);
        ProdutoDTO GetById(int id);
        void Remove(int id);
    }
}
