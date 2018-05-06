using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dinjo.Base.Domain;

namespace Dinjo.Base.Contracts.Services
{
    public interface IManager<T> where T : Entity
    {
        T Create(T entity);

        T GetById(int Id);

        List<T> GetAll();

        T Update(T entity);

        bool Delete(T entity);

        bool Deactivate(T entity);
    }
}
