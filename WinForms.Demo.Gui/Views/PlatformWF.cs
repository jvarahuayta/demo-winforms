using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Demo.Gui.Views.Base;
using WinForms.Demo.Gui.Core.Contracts.Views;
using WinForms.Demo.Gui.Core.Contracts.Presenters;

namespace WinForms.Demo.Gui.Views
{
    public partial class PlatformWF : BaseWF, IPlatformView
    {
        IPlatformPresenter presenter;
        ITeamMemberListView teamMemberView;
        ITodoListView todosView;

        public PlatformWF(IPlatformPresenter presenter,
            ITeamMemberListView teamMembersView,
            ITodoListView todosView)
        {
            InitializeComponent();
            this.presenter = presenter;
            this.teamMemberView = teamMembersView;
            this.todosView = todosView;
            presenter.SetView(this);
        }

        public void GoToModule(string moduleName)
        {
            switch (moduleName)
            {
                case "TEAM_MEMBERS":
                    teamMemberView.Init();
                    break;
                case "TODOS":
                    todosView.Init();
                    break;
            }
        }

        public override void Init()
        {

        }

        private void btnTeamMembers_Click(object sender, EventArgs e)
        {
            presenter.OnModuleClick("TEAM_MEMBERS");
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            presenter.OnModuleClick("TODOS");
        }
    }
}
