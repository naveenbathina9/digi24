using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Repository.Infrastructure
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        int Create(T entity);
        List<T> GetAll();
        T GetById(object key);
        bool Update(T entity);
        bool Delete(object key);
    }
}
