using System.Collections.Generic;

namespace Amr_ASP_Project.contract
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        T FindById(int id);
        bool isExist(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
