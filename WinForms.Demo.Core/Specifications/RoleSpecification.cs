using Dinjo.Base.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;

namespace WinForms.Demo.Core.Specifications
{
    public abstract class RoleSpecification : Specification<Role>
    {

    }

    public class RolesInTeamMemberSpecification : RoleSpecification
    {
        public TeamMember teamMember;

        public RolesInTeamMemberSpecification(TeamMember teamMember)
        {
            this.teamMember = teamMember;
        }

        public override Expression<Func<Role, bool>> ToExpression()
        {
            return (r) => r.TeamMembers.Select(t => t.Id).Contains(teamMember.Id);
        }
    }
}
