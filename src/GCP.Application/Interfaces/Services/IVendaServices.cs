using GCP.App.DTO.Venda;
using System.Data;

namespace GCP.App.Interfaces.Services
{
    public interface IVendaServices
    {
        void Add(VendaDTO dto);
        ObterVendaDTO GetById(int id);
        IEnumerable<ObterVendaDTO> GetAllWithClienteRelations();
        DataTable GetDataTableWithClienteRelations();
        IList<ObterVendaDTO> SearchWithClienteRelations(string search);
    }
}
