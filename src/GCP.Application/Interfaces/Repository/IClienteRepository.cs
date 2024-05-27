using GCP.App.Interfaces.Generic;
using GCP.Core.Entities;

namespace GCP.App.Interfaces.Repository
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        bool ExistePorCpf(string cpf);
        Cliente? GetByCpf(string cpf);
    }
}
