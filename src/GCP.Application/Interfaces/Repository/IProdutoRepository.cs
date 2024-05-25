using GCP.App.Interfaces.Generic;
using GCP.Core.Entities;

namespace GCP.App.Interfaces.Repository
{
    public interface IProdutoRepository : IGenericRepository<Produto>
    {
        bool ExistByCode(string? code);
    }
}
