using Dinjo.Base.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Demo.Core.Domain
{
    public class Role: Entity
    {
        public string Name { get; set; }

        public virtual List<TeamMember> TeamMembers { get; set; }
        public virtual List<Todo> Todos { get; set; }
    }
}
