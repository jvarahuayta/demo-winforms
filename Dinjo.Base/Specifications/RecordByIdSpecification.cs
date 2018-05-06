using Dinjo.Base.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dinjo.Base.Specifications
{
    public class RecordByIdSpecification<T>: Specification<T> where T : Entity
    {
        public int Id;

        public RecordByIdSpecification(int Id)
        {
            this.Id = Id;
        }


        public override Expression<Func<T, bool>> ToExpression()
        {
            return (x) => x.Id == this.Id;
        }
    }
}
