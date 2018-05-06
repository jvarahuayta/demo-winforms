using Dinjo.Base.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;
using System.Linq.Expressions;

namespace WinForms.Demo.Core.Specifications
{
    public abstract class TeamMemberSpecification : Specification<TeamMember>
    {

    }

    public class TeamMembersInRoleSpecification : TeamMemberSpecification
    {
        public Role role;

        public TeamMembersInRoleSpecification(Role role)
        {
            this.role = role;
        }

        public override Expression<Func<TeamMember, bool>> ToExpression()
        {
            return (t) => t.Roles.Select(r => r.Id).Contains(role.Id);
        }
    }
}
