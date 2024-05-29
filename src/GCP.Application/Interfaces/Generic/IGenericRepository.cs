using GCP.Core.Entities.Generic;
using System.Data;

namespace GCP.App.Interfaces.Generic
{
    public interface IGenericRepository<T> where T : Entity
    {
        int Add(T entity, IDbTransaction transaction = null);
        int Update(T entity);
        T? GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Search(string search);
        int Remove(int id);
        IDbTransaction BeginTransaction();
    }
}
