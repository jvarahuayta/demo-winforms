using Dinjo.Base.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Repositories;
using Dinjo.Base.Specifications;
using WinForms.Demo.Core.Domain;
using Dinjo.Logs.Contracts;
using WinForms.Demo.Core.Domain.Shared;
using Dinjo.Base.Utils;
using WinForms.Demo.Infrastructure.Repositories.Base;
using WinForms.Demo.Core.Specifications;

namespace WinForms.Demo.Infrastructure.Repositories
{
    public class EFTeamMembersRepository : EFBaseRepository<TeamMember>, ITeamMembersRepository
    {
        public EFTeamMembersRepository(ILogger iLogger) : base(iLogger, DbTodosContext.DbSetEnum.TEAM_MEMBERS)
        {
        }

        public override List<TeamMember> GetList(Specification<TeamMember> specification = null)
        {
            if (specification is TeamMembersInRoleSpecification)
            {
                using (var db = new DbTodosContext())
                {
                    return db.Roles.First(x => x.Id == (specification as TeamMembersInRoleSpecification).role.Id).TeamMembers;
                }
            }
            return base.GetList(specification);
        }
    }
}
