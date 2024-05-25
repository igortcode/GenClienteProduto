using GCP.Core.Entities.Generic;

namespace GCP.Application.Interfaces.Generic
{
    public interface IGenericRepository<T> where T : Entity
    {
        int Add(T entity);
        int Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        int Remove(int id);
    }
}
