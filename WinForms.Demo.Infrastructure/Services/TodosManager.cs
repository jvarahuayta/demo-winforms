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

namespace WinForms.Demo.Infrastructure.Services
{
    public class TodosManager : BaseManager<Todo>, ITodosManager
    {
        public TodosManager(IRepository<Todo> repository, ILogger iLogger) : base(repository, iLogger)
        {
        }

        public List<Todo> GetTodosFor(TeamMember teamMember)
        {
            try
            {
                return repository.GetList(new TodosInTeamMemberSpecification(teamMember));
            }
            catch (Exception ex) when (!ex.GetType().IsSubclassOf(typeof(BaseRepository)))
            {
                logger.Exception(ex);

                throw new ServiceException();
            }
        }
    }
}
