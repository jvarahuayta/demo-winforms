using Dinjo.Logs;
using Dinjo.Logs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;
using WinForms.Demo.Core.Domain.Shared;
using WinForms.Demo.Core.Repositories;
using WinForms.Demo.Core.Services;
using WinForms.Demo.Infrastructure.Repositories;
using WinForms.Demo.Infrastructure.Services;

namespace WinForms.Demo.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new NLogLogger("test");
            ITeamMembersRepository teamMembersRepository = new EFTeamMembersRepository(logger);
            IRolesRepository rolesRepository = new EFRolesRepository(logger);
            ITodosRepository todosrepository = new EFTodosRepository(logger);
            ITeamMembersManager teamMembersManager = new TeamMembersManager(teamMembersRepository, logger);
            IRolesManager rolesManager = new RolesManager(rolesRepository, logger);
            ITodosManager todosManager = new TodosManager(todosrepository, logger);

            var roleList = rolesManager.GetAll();
            var scrumMasterRole = rolesManager.GetById(1);
            var josafat = teamMembersManager.GetById(2);
            rolesManager.SetRolesFor(josafat, new List<Role>() { scrumMasterRole });

        }
    }
}
