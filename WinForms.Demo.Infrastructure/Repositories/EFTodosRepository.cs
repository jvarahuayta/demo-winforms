using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dinjo.Base.Specifications;
using Dinjo.Logs.Contracts;
using WinForms.Demo.Core.Domain;
using WinForms.Demo.Core.Domain.Shared;
using WinForms.Demo.Core.Repositories;
using WinForms.Demo.Infrastructure.Repositories.Base;
using WinForms.Demo.Core.Specifications;

namespace WinForms.Demo.Infrastructure.Repositories
{
    public class EFTodosRepository : EFBaseRepository<Todo>, ITodosRepository
    {
        public EFTodosRepository(ILogger iLogger) : base(iLogger, DbTodosContext.DbSetEnum.TODOS)
        {
        }

        public override List<Todo> GetList(Specification<Todo> specification = null)
        {
            if (specification is TodosInTeamMemberSpecification)
            {
                using (var db = new DbTodosContext())
                {
                    return db.TeamMembers.First(x => x.Id == (specification as TodosInTeamMemberSpecification).teamMember.Id).Todos;
                }
            }
            return base.GetList(specification);
        }
    }
}
