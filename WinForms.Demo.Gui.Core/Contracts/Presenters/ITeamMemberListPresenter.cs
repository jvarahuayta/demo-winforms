using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;
using WinForms.Demo.Gui.Core.Contracts.Presenters.Base;
using WinForms.Demo.Gui.Core.Contracts.Views;

namespace WinForms.Demo.Gui.Core.Contracts.Presenters
{
    public interface ITeamMemberListPresenter: IEntityListPresenter<TeamMember, ITeamMemberListView>
    {

    }
}
