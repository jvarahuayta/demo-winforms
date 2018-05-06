using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;
using WinForms.Demo.Core.Services;
using WinForms.Demo.Gui.Core.Contracts.Presenters;
using WinForms.Demo.Gui.Core.Contracts.Views;
using WinForms.Demo.Gui.Core.Contracts.Views.Base;

namespace WinForms.Demo.Gui.Presenters
{
    public class TeamMemberListPresenter : Base.BasePresenter<ITeamMemberListView>, ITeamMemberListPresenter
    {
        protected ITeamMembersManager manager;

        public TeamMemberListPresenter(ITeamMembersManager manager)
        {
            this.manager = manager;
        }

        public void LoadEntities()
        {
            view.ShowEntities( manager.GetAll() );
        }

        public void OnConfirmDeleteEntity(bool result)
        {
            throw new NotImplementedException();
        }

        public void OnCreateEntity()
        {
            view.GoToCreateEntity();
        }

        public void OnDeleteEntity(TeamMember entity)
        {
            if (view.OpenConfirmDialog())
            {
                manager.Delete(entity);
                LoadEntities();
            }
        }

        public void OnEditEntity(TeamMember entity)
        {
            view.GoToEditEntity(entity);
        }
    }
}
