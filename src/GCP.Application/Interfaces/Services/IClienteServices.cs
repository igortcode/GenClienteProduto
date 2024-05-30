using GCP.App.DTO.Clientes;
using System.Data;

namespace GCP.App.Interfaces.Services
{
    public interface IClienteServices
    {
        void Add(ClienteDTO dto);
        void Update(ClienteDTO dto);
        IEnumerable<ClienteDTO> GetAll();
        DataTable GetDataTable();
        IEnumerable<ClienteDTO> Search(string search);
        ClienteDTO GetById(int id);
        ClienteDTO GetByCpf(string cpf);
        void Remove(int id);
    }
}
