using Dinjo.Base.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;

namespace WinForms.Demo.Core.Services
{
    public interface IRolesManager: IManager<Role>
    {
        List<Role> GetRolesFor(TeamMember teamMember);

        void SetRolesFor(TeamMember teamMember, List<Role> roles);
    }
}
