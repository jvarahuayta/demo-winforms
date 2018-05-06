using Dinjo.Base.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Demo.Core.Domain
{
    public class Todo : Entity
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public bool Finished { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public virtual List<Role> Roles { get; set; }
        public virtual List<TeamMember> TeamMembers { get; set; }
    }
}
