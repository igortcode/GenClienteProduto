using GCP.App.DTO.Venda;

namespace GCP.App.Interfaces.Services
{
    public interface IVendaServices
    {
        void Add(VendaDTO dto);
        VendaDTO GetById(int id);
        IEnumerable<VendaDTO> GetAll();
        void Remover(int id);
    }
}
