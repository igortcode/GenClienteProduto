using GCP.App.DTO.Venda;

namespace GCP.App.Interfaces.Services
{
    public interface IVendaServices
    {
        void Add(VendaDTO dto);
        ObterVendaDTO GetById(int id);
        IEnumerable<ObterVendaDTO> GetAllWithClienteRelations();
        IList<ObterVendaDTO> SearchWithClienteRelations(string search);
    }
}
