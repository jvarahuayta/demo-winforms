using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;
using WinForms.Demo.Core.Services;
using WinForms.Demo.Gui.Core.Contracts.Presenters;
using WinForms.Demo.Gui.Core.Contracts.Views;
using WinForms.Demo.Gui.Presenters.Base;

namespace WinForms.Demo.Gui.Presenters
{
    public class TeamMemberDetailsPresenter : BasePresenter<ITeamMemberDetailsView>, ITeamMemberDetailsPresenter
    {
        ITeamMembersManager manager;

        public TeamMemberDetailsPresenter(ITeamMembersManager manager)
        {
            this.manager = manager;
        }

        public void OnSave(TeamMember entity)
        {
            if(entity.Id == null)
            {
                manager.Create(entity);
            }else
            {
                manager.Update(entity);
            }
            view.Hide();
            view.OnClose(true);
        }
    }
}
