using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dinjo.Base.Domain;
using Dinjo.Base.Specifications;

namespace Dinjo.Base.Contracts.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        T Get(Specification<T> specification = null);

        List<T> GetList(Specification<T> specification = null);

        T Add(T entity);

        T Update(T entity);

        T Delete(T entity);
    }
}
