using Dinjo.Base.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;
using WinForms.Demo.Core.Services;
using Dinjo.Base.Contracts.Repositories;
using Dinjo.Logs.Contracts;
using Dinjo.Base.Infrastructure.Repositories;
using Dinjo.Base.Exceptions;
using WinForms.Demo.Core.Specifications;

namespace WinForms.Demo.Infrastructure.Services
{
    public class TeamMembersManager : BaseManager<TeamMember>, ITeamMembersManager
    {
        public TeamMembersManager(IRepository<TeamMember> repository, ILogger iLogger) : base(repository, iLogger)
        {
        }

        public List<TeamMember> GetTeamMembersFor(Role role)
        {
            try
            {
                return repository.GetList(new TeamMembersInRoleSpecification(role));
            }
            catch (Exception ex) when (!ex.GetType().IsSubclassOf(typeof(BaseRepository)))
            {
                logger.Exception(ex);

                throw new ServiceException();
            }
        }
    }
}
