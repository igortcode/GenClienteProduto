using GCP.Core.Entities.Generic;

namespace GCP.App.Interfaces.Generic
{
    public interface IGenericRepository<T> where T : Entity
    {
        int Add(T entity);
        int Update(T entity);
        T? GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Search(string search);
        int Remove(int id);
    }
}
