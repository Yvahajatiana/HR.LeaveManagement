using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Persistence.Contract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAll();

        Task<T> Get(int id);

        Task Delete(T entity);

        Task<T> Update(T entity);

        Task<T> Add(T entity);
    }
}
