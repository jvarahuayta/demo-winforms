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
using WinForms.Demo.Core.Specifications;
using Dinjo.Base.Infrastructure.Repositories;
using Dinjo.Base.Exceptions;
using WinForms.Demo.Core.Repositories;

namespace WinForms.Demo.Infrastructure.Services
{
    public class RolesManager : BaseManager<Role>, IRolesManager
    {
        public RolesManager(IRepository<Role> repository, ILogger iLogger) : base(repository, iLogger)
        {
        }

        public List<Role> GetRolesFor(TeamMember teamMember)
        {
            try
            {
                return repository.GetList(new RolesInTeamMemberSpecification(teamMember));
            }
            catch (Exception ex) when (!ex.GetType().IsSubclassOf(typeof(BaseRepository)))
            {
                logger.Exception(ex);

                throw new ServiceException();
            }
        }

        public void SetRolesFor(TeamMember teamMember, List<Role> role)
        {
            try
            {
                (repository as IRolesRepository).setRolesFor(teamMember, role);
            }
            catch (Exception ex) when (!ex.GetType().IsSubclassOf(typeof(BaseRepository)))
            {
                logger.Exception(ex);

                throw new ServiceException();
            }
        }
    }
}
