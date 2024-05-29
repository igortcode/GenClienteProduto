using GCP.App.DTO.Venda;
using GCP.App.Interfaces.Generic;
using GCP.Core.Entities;

namespace GCP.App.Interfaces.Repository
{
    public interface IVendaRepository : IGenericRepository<Venda>
    {
        IEnumerable<ObterVendaDTO> GetAllWithClienteRelations();
        IList<ObterVendaDTO> SearchWithClienteRelations(string search);
        ObterVendaDTO GetByIdWithClienteRelations(int idVenda);
    }
}
