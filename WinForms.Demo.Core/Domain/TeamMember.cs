using Dinjo.Base.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Demo.Core.Domain
{
    public class TeamMember: Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual List<Role> Roles { get; set; }
        public virtual List<Todo> Todos { get; set; }
    }
}
