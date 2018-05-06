using Dinjo.Base.Infrastructure.Repositories;
using Dinjo.Base.Specifications;
using Dinjo.Base.Utils;
using Dinjo.Logs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;
using WinForms.Demo.Core.Domain.Shared;
using WinForms.Demo.Core.Repositories;
using WinForms.Demo.Core.Specifications;
using WinForms.Demo.Infrastructure.Repositories.Base;

namespace WinForms.Demo.Infrastructure.Repositories
{
    public class EFRolesRepository: EFBaseRepository<Role>, IRolesRepository
    {
        public EFRolesRepository(ILogger iLogger) : base(iLogger, DbTodosContext.DbSetEnum.ROLES)
        {
        }

        public override List<Role> GetList(Specification<Role> specification = null)
        {
            if(specification is RolesInTeamMemberSpecification)
            {
                using (var db = new DbTodosContext())
                {
                    return db.TeamMembers.First( t => t.Id == (specification as RolesInTeamMemberSpecification).teamMember.Id ).Roles;
                }
            }
            return base.GetList(specification);
        }

        public void setRolesFor(TeamMember teamMember, List<Role> roles)
        {
            using (var db = new DbTodosContext())
            {
                var roleIds = roles.Select(r => r.Id).ToList();
                teamMember = db.TeamMembers.First(x => x.Id == teamMember.Id);
                roles = db.Roles.Where(r => roleIds.Contains(r.Id)).ToList();
                teamMember.Roles.Clear();
                teamMember.Roles.AddRange(roles);
                db.SaveChanges();
            }
        }
    }
}
