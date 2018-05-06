using Dinjo.Base.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;

namespace WinForms.Demo.Core.Services
{
    public interface ITodosManager: IManager<Todo>
    {
        List<Todo> GetTodosFor(TeamMember teamMember);


    }
}
