using Dinjo.Base.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;

namespace WinForms.Demo.Core.Repositories
{
    public interface IRolesRepository: IRepository<Role>
    {
        void setRolesFor(TeamMember teamMember, List<Role> roles);
    }
}
