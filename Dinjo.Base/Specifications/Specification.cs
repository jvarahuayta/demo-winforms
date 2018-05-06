using Dinjo.Base.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dinjo.Base.Specifications
{
    public abstract class Specification<T> where T : Entity
    {
        public abstract Expression<Func<T, bool>> ToExpression();

        //public bool IsSatisfiedBy(T entity)
        //{
        //    return expression(entity);
        //}

    }


}
